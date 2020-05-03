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
        private bool isDark = true;

        private readonly Selections selections = new Selections();

        public Main()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e) => this.Dispose();

        private void minimizeBtn_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void LoadBtn_Click(object sender, EventArgs e)
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select text file to open",
                Filter = "Text files (*.txt)|*.txt|All files (Will load as plain text file) (*.*)|*.*",
                CheckFileExists = false
            };
            fileDialog.ShowDialog();
            if (fileDialog.FileName == "") return;
            File.WriteAllText(fileDialog.FileName, text.Text + "\n" + JsonConvert.SerializeObject(selections.selections));
        }

        private void Replace(string type, Color color)
        {
            int from = 0, to = 0;

            if (text.SelectionLength != 0)
            {
                to = text.SelectionStart + text.SelectionLength;
                from = text.SelectionStart;
                text.Text = text.Text.Substring(0, from) + $"<{type}>" + text.Text.Substring(from, to - from) + $"</{type}>" + text.Text.Substring(to);
                text.SelectionStart = from + type.Length + 2;
                text.SelectionLength = to - from;
                text.SelectionColor = color;
                selections.selections.Add(new TripleData() { from = text.SelectionStart, to = text.SelectionStart + text.SelectionLength, type = type });
            }
            
            if (rText.Text == "") return;
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

        private void PersonBtn_Click(object sender, EventArgs e)
        {
            if (rText.Text != "")
                text.Text = text.Text.Replace(rText.Text, $"<person>{rText.Text}</person>");
            Replace("person", Color.BlueViolet);
        }

        private void PlaceBtn_Click(object sender, EventArgs e)
        {
            if (rText.Text != "")
                text.Text = text.Text.Replace(rText.Text, $"<place>{rText.Text}</place>");
            Replace("place", Color.Aqua);
        }

        private void EventBtn_Click(object sender, EventArgs e)
        {
            if (rText.Text != "")
                text.Text = text.Text.Replace(rText.Text, $"<event>{rText.Text}</event>");
            Replace("event", Color.Red);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            text.Clear();
            selections.selections.Clear();
        }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            if (isDark)
            {
                this.BackColor = Color.White;
                this.personBtn.BackColor = this.placeBtn.BackColor = this.eventBtn.BackColor = this.ThemeBtn.BackColor = this.clearBtn.BackColor = this.saveEncBtn.BackColor = this.saveBtn.BackColor = this.loadBtn.BackColor = Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(00)))), ((int)(((byte)(238)))));
                this.rText.BackColor = this.text.BackColor = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
                this.rText.ForeColor = this.text.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
                this.rText.BackColor = this.text.BackColor = this.personBtn.BackColor = this.placeBtn.BackColor = this.eventBtn.BackColor = this.ThemeBtn.BackColor = this.clearBtn.BackColor = this.saveEncBtn.BackColor = this.saveBtn.BackColor = this.loadBtn.BackColor = Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
                this.rText.ForeColor = this.text.ForeColor = Color.White;
            }
            isDark = !isDark;
        }
    }
}
