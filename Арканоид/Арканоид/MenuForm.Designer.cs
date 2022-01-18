namespace Арканоид
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_button.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(351, 389);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(269, 76);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Начать игру";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Арканоид.Properties.Resources.заставка_арканоида;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(978, 563);
            this.Controls.Add(this.start_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арканоид";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
    }
}

