namespace ParseApps
{
    partial class ImageDebug
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
            this.debugImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.debugImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // debugImageBox
            // 
            this.debugImageBox.Location = new System.Drawing.Point(25, 27);
            this.debugImageBox.Name = "debugImageBox";
            this.debugImageBox.Size = new System.Drawing.Size(616, 904);
            this.debugImageBox.TabIndex = 0;
            this.debugImageBox.TabStop = false;
            // 
            // ImageDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 952);
            this.Controls.Add(this.debugImageBox);
            this.Name = "ImageDebug";
            this.Text = "Image Debug";
            ((System.ComponentModel.ISupportInitialize)(this.debugImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox debugImageBox;
    }
}