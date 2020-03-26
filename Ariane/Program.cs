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
using System.Linq;
using System.Windows.Forms;

namespace Ariane
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Drawing.Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            if (screenSize.Width < 1300 || screenSize.Height < 900)
            {
                MessageBox.Show("Your screen size is smaller that the minimum of (1300px)x(900px).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
