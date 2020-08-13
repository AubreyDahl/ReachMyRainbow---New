namespace ReachMyRainbow___New
{
    partial class FormQuitPopUp
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
            this.buttonQuitYes = new System.Windows.Forms.Button();
            this.buttonQuitNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuitYes
            // 
            this.buttonQuitYes.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.buttonQuitYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonQuitYes.Font = new System.Drawing.Font("Juice ITC", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.buttonQuitYes.Location = new System.Drawing.Point(194, 347);
            this.buttonQuitYes.Name = "buttonQuitYes";
            this.buttonQuitYes.Size = new System.Drawing.Size(218, 132);
            this.buttonQuitYes.TabIndex = 0;
            this.buttonQuitYes.Text = "Yes";
            this.buttonQuitYes.UseVisualStyleBackColor = true;
            this.buttonQuitYes.Click += new System.EventHandler(this.buttonQuitYes_Click);
            // 
            // buttonQuitNo
            // 
            this.buttonQuitNo.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.Button_Base;
            this.buttonQuitNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonQuitNo.Font = new System.Drawing.Font("Juice ITC", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.buttonQuitNo.Location = new System.Drawing.Point(697, 347);
            this.buttonQuitNo.Name = "buttonQuitNo";
            this.buttonQuitNo.Size = new System.Drawing.Size(218, 132);
            this.buttonQuitNo.TabIndex = 1;
            this.buttonQuitNo.Text = "No";
            this.buttonQuitNo.UseVisualStyleBackColor = true;
            this.buttonQuitNo.Click += new System.EventHandler(this.buttonQuitNo_Click);
            // 
            // FormQuitPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReachMyRainbow___New.Properties.Resources.menu_no_buttons;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 584);
            this.Controls.Add(this.buttonQuitNo);
            this.Controls.Add(this.buttonQuitYes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormQuitPopUp";
            this.Text = "FormQuitPopUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitYes;
        private System.Windows.Forms.Button buttonQuitNo;
    }
}