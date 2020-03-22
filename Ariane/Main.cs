/**
 * Ariane
 * Copyright (C) 2020  Richard Bariampa
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 *
 * Maintainers:
 * Richard Bariampa (richardbar) <richard1996ba@gmail.com>, <richard2003ba@outlook.com>
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Ariane
{
    public partial class Main : Form
    {
        private Selections selections = new Selections();

        public Main()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e) => this.Dispose();

        private void minimizeBtn_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select text file to open",
                Filter = "Text files (*.txt)|*.txt|All files (Will load as plain text file) (*.*)|*.*",
                CheckFileExists = true,
                CheckPathExists = true
            };
            fileDialog.ShowDialog();
            if (fileDialog.FileName == "") return;
            text.Text = File.ReadAllText(fileDialog.FileName);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select text file to open",
                Filter = "Text files (*.txt)|*.txt|All files (Will load as plain text file) (*.*)|*.*",
                CheckPathExists = true
            };
            fileDialog.ShowDialog();
            if (fileDialog.FileName == "") return;
            File.WriteAllText(fileDialog.FileName, text.Text + "\n" + JsonConvert.SerializeObject(selections.selections));
        }

        private void replace(string type, Color color)
        {
            if (text.SelectionLength != 0)
            {
                text.SelectionColor = color;
                selections.selections.Add(new TripleData() { from = text.SelectionStart, to = text.SelectionStart + text.SelectionLength, type = type });
            }
                if (rText.Text == "") return;
            int from = 0, to = 0;
            while (true)
            {
                from = text.Text.IndexOf(rText.Text, to);
                if (from == -1) break;
                to = from + rText.Text.Length;
                text.SelectionStart = from;
                text.SelectionLength = to - from;
                text.SelectionColor = color;
                selections.selections.Add(new TripleData() { from = from, to = to, type = type });
            }
            text.SelectionLength = 0;
            rText.Clear();
            return;
        }

        private void personBtn_Click(object sender, EventArgs e)
        {
            if (rText.Text != "")
                text.Text = text.Text.Replace(rText.Text, $"<person>{rText.Text}</person>");
            replace("person", Color.BlueViolet);
        }

        private void placeBtn_Click(object sender, EventArgs e)
        {
            if (rText.Text != "")
                text.Text = text.Text.Replace(rText.Text, $"<place>{rText.Text}</place>");
            replace("place", Color.Aqua);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            text.Clear();
            selections.selections.Clear();
        }
    }
}
