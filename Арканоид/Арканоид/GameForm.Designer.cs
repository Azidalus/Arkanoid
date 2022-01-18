namespace Арканоид
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.paddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 28;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // paddle
            // 
            this.paddle.Image = global::Арканоид.Properties.Resources.ракетка1;
            this.paddle.Location = new System.Drawing.Point(437, 583);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(108, 32);
            this.paddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paddle.TabIndex = 1;
            this.paddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::Арканоид.Properties.Resources.мяч;
            this.ball.Location = new System.Drawing.Point(475, 558);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(33, 29);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(978, 637);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арканоид";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosing);
            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.Timer timer;
    }
}