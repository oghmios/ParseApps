namespace ParseApps
{
    partial class DebugWindow
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
            this.captureCroppedButton = new System.Windows.Forms.Button();
            this.captureImageButton = new System.Windows.Forms.Button();
            this.textParsedBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // captureCroppedButton
            // 
            this.captureCroppedButton.Location = new System.Drawing.Point(223, 48);
            this.captureCroppedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.captureCroppedButton.Name = "captureCroppedButton";
            this.captureCroppedButton.Size = new System.Drawing.Size(132, 31);
            this.captureCroppedButton.TabIndex = 48;
            this.captureCroppedButton.Text = "Capture Cropped";
            this.captureCroppedButton.UseVisualStyleBackColor = true;
            this.captureCroppedButton.Click += new System.EventHandler(this.captureDebugButton_Click);
            // 
            // captureImageButton
            // 
            this.captureImageButton.Location = new System.Drawing.Point(64, 48);
            this.captureImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.captureImageButton.Name = "captureImageButton";
            this.captureImageButton.Size = new System.Drawing.Size(108, 31);
            this.captureImageButton.TabIndex = 0;
            this.captureImageButton.Text = "Capture Image";
            this.captureImageButton.UseVisualStyleBackColor = true;
            this.captureImageButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textParsedBox
            // 
            this.textParsedBox.Location = new System.Drawing.Point(64, 102);
            this.textParsedBox.Multiline = true;
            this.textParsedBox.Name = "textParsedBox";
            this.textParsedBox.Size = new System.Drawing.Size(291, 144);
            this.textParsedBox.TabIndex = 49;
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 293);
            this.Controls.Add(this.textParsedBox);
            this.Controls.Add(this.captureCroppedButton);
            this.Controls.Add(this.captureImageButton);
            this.Name = "DebugWindow";
            this.Text = "DebugWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button captureCroppedButton;
        private System.Windows.Forms.Button captureImageButton;
        private System.Windows.Forms.TextBox textParsedBox;
    }
}