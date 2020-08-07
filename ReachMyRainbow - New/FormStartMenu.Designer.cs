namespace ReachMyRainbow___New
{
    partial class FormStartMenu
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
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonCredits = new System.Windows.Forms.Button();
            this.ButtonOptions = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Font = new System.Drawing.Font("Juice ITC", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.ButtonPlay.Image = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.ButtonPlay.Location = new System.Drawing.Point(201, 555);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(237, 133);
            this.ButtonPlay.TabIndex = 0;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonCredits
            // 
            this.ButtonCredits.Font = new System.Drawing.Font("Juice ITC", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.ButtonCredits.Image = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.ButtonCredits.Location = new System.Drawing.Point(605, 555);
            this.ButtonCredits.Name = "ButtonCredits";
            this.ButtonCredits.Size = new System.Drawing.Size(237, 133);
            this.ButtonCredits.TabIndex = 1;
            this.ButtonCredits.Text = "Credits";
            this.ButtonCredits.UseVisualStyleBackColor = true;
            this.ButtonCredits.Click += new System.EventHandler(this.ButtonCredits_Click);
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Font = new System.Drawing.Font("Juice ITC", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.ButtonOptions.Image = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.ButtonOptions.Location = new System.Drawing.Point(992, 555);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(237, 133);
            this.ButtonOptions.TabIndex = 2;
            this.ButtonOptions.Text = "Options";
            this.ButtonOptions.UseVisualStyleBackColor = true;
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Font = new System.Drawing.Font("Juice ITC", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.ButtonQuit.Image = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.ButtonQuit.Location = new System.Drawing.Point(1431, 555);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(237, 133);
            this.ButtonQuit.TabIndex = 3;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // FormStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Title_Screen___No_Buttons;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonOptions);
            this.Controls.Add(this.ButtonCredits);
            this.Controls.Add(this.ButtonPlay);
            this.Name = "FormStartMenu";
            this.Text = "FormStartMenu";
            this.Load += new System.EventHandler(this.FormStartMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonCredits;
        private System.Windows.Forms.Button ButtonOptions;
        private System.Windows.Forms.Button ButtonQuit;
    }
}