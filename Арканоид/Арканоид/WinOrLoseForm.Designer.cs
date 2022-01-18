namespace Арканоид
{
    partial class WinOrLoseForm
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
            this.PlayAgain = new System.Windows.Forms.Button();
            this.GoToMenu = new System.Windows.Forms.Button();
            this.LoseWin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayAgain.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayAgain.Location = new System.Drawing.Point(55, 203);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(155, 69);
            this.PlayAgain.TabIndex = 0;
            this.PlayAgain.Text = "Играть \r\nснова";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // GoToMenu
            // 
            this.GoToMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GoToMenu.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToMenu.Location = new System.Drawing.Point(266, 203);
            this.GoToMenu.Name = "GoToMenu";
            this.GoToMenu.Size = new System.Drawing.Size(155, 69);
            this.GoToMenu.TabIndex = 1;
            this.GoToMenu.Text = "В меню";
            this.GoToMenu.UseVisualStyleBackColor = false;
            this.GoToMenu.Click += new System.EventHandler(this.GoToMenu_Click);
            // 
            // LoseWin
            // 
            this.LoseWin.BackColor = System.Drawing.SystemColors.InfoText;
            this.LoseWin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoseWin.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoseWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoseWin.Location = new System.Drawing.Point(39, 58);
            this.LoseWin.Multiline = true;
            this.LoseWin.Name = "LoseWin";
            this.LoseWin.ReadOnly = true;
            this.LoseWin.Size = new System.Drawing.Size(402, 102);
            this.LoseWin.TabIndex = 2;
            this.LoseWin.Text = "аы";
            this.LoseWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinOrLoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(479, 303);
            this.ControlBox = false;
            this.Controls.Add(this.LoseWin);
            this.Controls.Add(this.GoToMenu);
            this.Controls.Add(this.PlayAgain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinOrLoseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinOrLoseForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button GoToMenu;
        public System.Windows.Forms.TextBox LoseWin;
    }
}