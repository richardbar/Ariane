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

namespace Ariane
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text = new System.Windows.Forms.RichTextBox();
            this.rText = new System.Windows.Forms.TextBox();
            this.personBtn = new System.Windows.Forms.Button();
            this.placeBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.lightThemeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveEncBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(12, 29);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(742, 725);
            this.text.TabIndex = 0;
            this.text.Text = "";
            // 
            // rText
            // 
            this.rText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rText.ForeColor = System.Drawing.Color.White;
            this.rText.Location = new System.Drawing.Point(12, 760);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(742, 28);
            this.rText.TabIndex = 1;
            // 
            // personBtn
            // 
            this.personBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.personBtn.FlatAppearance.BorderSize = 0;
            this.personBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBtn.ForeColor = System.Drawing.Color.White;
            this.personBtn.Location = new System.Drawing.Point(760, 760);
            this.personBtn.Name = "personBtn";
            this.personBtn.Size = new System.Drawing.Size(138, 28);
            this.personBtn.TabIndex = 2;
            this.personBtn.Text = "Person";
            this.personBtn.UseVisualStyleBackColor = false;
            this.personBtn.Click += new System.EventHandler(this.personBtn_Click);
            // 
            // placeBtn
            // 
            this.placeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.placeBtn.FlatAppearance.BorderSize = 0;
            this.placeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBtn.ForeColor = System.Drawing.Color.White;
            this.placeBtn.Location = new System.Drawing.Point(905, 760);
            this.placeBtn.Name = "placeBtn";
            this.placeBtn.Size = new System.Drawing.Size(138, 28);
            this.placeBtn.TabIndex = 3;
            this.placeBtn.Text = "Place";
            this.placeBtn.UseVisualStyleBackColor = false;
            this.placeBtn.Click += new System.EventHandler(this.placeBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1050, 760);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(1177, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(23, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.BackColor = System.Drawing.Color.Gray;
            this.maximizeBtn.Enabled = false;
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.Location = new System.Drawing.Point(1154, 0);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(23, 23);
            this.maximizeBtn.TabIndex = 6;
            this.maximizeBtn.Text = "🗖";
            this.maximizeBtn.UseVisualStyleBackColor = false;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Yellow;
            this.minimizeBtn.Enabled = false;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(1131, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(23, 23);
            this.minimizeBtn.TabIndex = 7;
            this.minimizeBtn.Text = "🗕";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // lightThemeBtn
            // 
            this.lightThemeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lightThemeBtn.FlatAppearance.BorderSize = 0;
            this.lightThemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightThemeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightThemeBtn.ForeColor = System.Drawing.Color.White;
            this.lightThemeBtn.Location = new System.Drawing.Point(760, 256);
            this.lightThemeBtn.Name = "lightThemeBtn";
            this.lightThemeBtn.Size = new System.Drawing.Size(428, 50);
            this.lightThemeBtn.TabIndex = 16;
            this.lightThemeBtn.Text = "Light Theme";
            this.lightThemeBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(760, 200);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(428, 50);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveEncBtn
            // 
            this.saveEncBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.saveEncBtn.FlatAppearance.BorderSize = 0;
            this.saveEncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEncBtn.ForeColor = System.Drawing.Color.White;
            this.saveEncBtn.Location = new System.Drawing.Point(760, 144);
            this.saveEncBtn.Name = "saveEncBtn";
            this.saveEncBtn.Size = new System.Drawing.Size(428, 50);
            this.saveEncBtn.TabIndex = 18;
            this.saveEncBtn.Text = "Save Encoded";
            this.saveEncBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(760, 88);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(428, 50);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save To";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Location = new System.Drawing.Point(760, 29);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(428, 50);
            this.loadBtn.TabIndex = 20;
            this.loadBtn.Text = "Load From";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.saveEncBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.lightThemeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.maximizeBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.placeBtn);
            this.Controls.Add(this.personBtn);
            this.Controls.Add(this.rText);
            this.Controls.Add(this.text);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.TextBox rText;
        private System.Windows.Forms.Button personBtn;
        private System.Windows.Forms.Button placeBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button maximizeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button lightThemeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveEncBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
    }
}