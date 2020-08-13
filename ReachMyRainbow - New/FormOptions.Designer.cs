namespace ReachMyRainbow___New
{
    partial class FormOptions
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
            this.ButtonBackOptions = new System.Windows.Forms.Button();
            this.ComingSoon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonBackOptions
            // 
            this.ButtonBackOptions.Font = new System.Drawing.Font("Juice ITC", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.ButtonBackOptions.Image = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.ButtonBackOptions.Location = new System.Drawing.Point(12, 888);
            this.ButtonBackOptions.Name = "ButtonBackOptions";
            this.ButtonBackOptions.Size = new System.Drawing.Size(237, 133);
            this.ButtonBackOptions.TabIndex = 7;
            this.ButtonBackOptions.Text = "Back";
            this.ButtonBackOptions.UseVisualStyleBackColor = true;
            this.ButtonBackOptions.Click += new System.EventHandler(this.ButtonBackOptions_Click);
            // 
            // ComingSoon
            // 
            this.ComingSoon.Font = new System.Drawing.Font("Monotype Corsiva", 100F, System.Drawing.FontStyle.Italic);
            this.ComingSoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(9)))), ((int)(((byte)(34)))));
            this.ComingSoon.Location = new System.Drawing.Point(600, 291);
            this.ComingSoon.Name = "ComingSoon";
            this.ComingSoon.Size = new System.Drawing.Size(902, 195);
            this.ComingSoon.TabIndex = 8;
            this.ComingSoon.Text = "Coming Soon";
            this.ComingSoon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Options;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ComingSoon);
            this.Controls.Add(this.ButtonBackOptions);
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBackOptions;
        private System.Windows.Forms.TextBox ComingSoon;
    }
}