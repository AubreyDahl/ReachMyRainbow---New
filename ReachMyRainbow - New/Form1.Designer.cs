namespace ReachMyRainbow___New
{
    partial class Quit
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.buttonPlay.Font = new System.Drawing.Font("Juice ITC", 45F);
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.buttonPlay.Location = new System.Drawing.Point(359, 511);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(277, 140);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonCredits
            // 
            this.buttonCredits.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.buttonCredits.Font = new System.Drawing.Font("Juice ITC", 45F);
            this.buttonCredits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.buttonCredits.Location = new System.Drawing.Point(749, 511);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(277, 140);
            this.buttonCredits.TabIndex = 1;
            this.buttonCredits.Text = "Credits";
            this.buttonCredits.UseVisualStyleBackColor = true;
            this.buttonCredits.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOptions.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.buttonOptions.Font = new System.Drawing.Font("Juice ITC", 45F);
            this.buttonOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.buttonOptions.Location = new System.Drawing.Point(1143, 511);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(277, 140);
            this.buttonOptions.TabIndex = 2;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.buttonQuit.Font = new System.Drawing.Font("Juice ITC", 45F);
            this.buttonQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.buttonQuit.Location = new System.Drawing.Point(1528, 511);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(277, 140);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Quit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Title_Screen___No_Buttons;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.buttonPlay);
            this.Name = "Quit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonQuit;
    }
}

