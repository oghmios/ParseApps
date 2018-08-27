namespace ParseApps
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textParsedBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.coordinatesButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imagePickedBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textParsedLabel = new System.Windows.Forms.Label();
            this.imagePickedLabel = new System.Windows.Forms.Label();
            this.lefTopLabel = new System.Windows.Forms.Label();
            this.lefTopLabelContainer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rightDownLabelContainer = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.colorPickerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePickedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textParsedBox
            // 
            this.textParsedBox.Location = new System.Drawing.Point(314, 673);
            this.textParsedBox.Margin = new System.Windows.Forms.Padding(2);
            this.textParsedBox.Multiline = true;
            this.textParsedBox.Name = "textParsedBox";
            this.textParsedBox.Size = new System.Drawing.Size(243, 60);
            this.textParsedBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // coordinatesButton
            // 
            this.coordinatesButton.Location = new System.Drawing.Point(28, 48);
            this.coordinatesButton.Margin = new System.Windows.Forms.Padding(2);
            this.coordinatesButton.Name = "coordinatesButton";
            this.coordinatesButton.Size = new System.Drawing.Size(97, 22);
            this.coordinatesButton.TabIndex = 4;
            this.coordinatesButton.Text = "Add coordinates";
            this.coordinatesButton.UseVisualStyleBackColor = true;
            this.coordinatesButton.Click += new System.EventHandler(this.coordinatesButton_Click);
            this.coordinatesButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coordinatesButton_KeyDown);
            // 
            // imagePickedBox
            // 
            this.imagePickedBox.Location = new System.Drawing.Point(28, 255);
            this.imagePickedBox.Name = "imagePickedBox";
            this.imagePickedBox.Size = new System.Drawing.Size(516, 367);
            this.imagePickedBox.TabIndex = 5;
            this.imagePickedBox.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textParsedLabel
            // 
            this.textParsedLabel.AutoSize = true;
            this.textParsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textParsedLabel.Location = new System.Drawing.Point(311, 642);
            this.textParsedLabel.Name = "textParsedLabel";
            this.textParsedLabel.Size = new System.Drawing.Size(83, 17);
            this.textParsedLabel.TabIndex = 7;
            this.textParsedLabel.Text = "Text parsed";
            // 
            // imagePickedLabel
            // 
            this.imagePickedLabel.AutoSize = true;
            this.imagePickedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imagePickedLabel.Location = new System.Drawing.Point(25, 642);
            this.imagePickedLabel.Name = "imagePickedLabel";
            this.imagePickedLabel.Size = new System.Drawing.Size(91, 17);
            this.imagePickedLabel.TabIndex = 8;
            this.imagePickedLabel.Text = "Image picked";
            // 
            // lefTopLabel
            // 
            this.lefTopLabel.AutoSize = true;
            this.lefTopLabel.Location = new System.Drawing.Point(28, 87);
            this.lefTopLabel.Name = "lefTopLabel";
            this.lefTopLabel.Size = new System.Drawing.Size(81, 13);
            this.lefTopLabel.TabIndex = 9;
            this.lefTopLabel.Text = "LeftTop Corner:";
            // 
            // lefTopLabelContainer
            // 
            this.lefTopLabelContainer.AutoSize = true;
            this.lefTopLabelContainer.Location = new System.Drawing.Point(164, 87);
            this.lefTopLabelContainer.Name = "lefTopLabelContainer";
            this.lefTopLabelContainer.Size = new System.Drawing.Size(0, 13);
            this.lefTopLabelContainer.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "RightDown Corner:";
            // 
            // rightDownLabelContainer
            // 
            this.rightDownLabelContainer.AutoSize = true;
            this.rightDownLabelContainer.Location = new System.Drawing.Point(164, 116);
            this.rightDownLabelContainer.Name = "rightDownLabelContainer";
            this.rightDownLabelContainer.Size = new System.Drawing.Size(0, 13);
            this.rightDownLabelContainer.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.Location = new System.Drawing.Point(152, 47);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(75, 23);
            this.colorPickerButton.TabIndex = 14;
            this.colorPickerButton.Text = "Pick color";
            this.colorPickerButton.UseVisualStyleBackColor = true;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click);
            this.colorPickerButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coordinatesButton_KeyDown);
            // 
            // colorPickerLabel
            // 
            this.colorPickerLabel.AutoSize = true;
            this.colorPickerLabel.Location = new System.Drawing.Point(244, 52);
            this.colorPickerLabel.Name = "colorPickerLabel";
            this.colorPickerLabel.Size = new System.Drawing.Size(66, 13);
            this.colorPickerLabel.TabIndex = 15;
            this.colorPickerLabel.Text = "Color picked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 777);
            this.Controls.Add(this.colorPickerLabel);
            this.Controls.Add(this.colorPickerButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rightDownLabelContainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lefTopLabelContainer);
            this.Controls.Add(this.lefTopLabel);
            this.Controls.Add(this.imagePickedLabel);
            this.Controls.Add(this.textParsedLabel);
            this.Controls.Add(this.imagePickedBox);
            this.Controls.Add(this.coordinatesButton);
            this.Controls.Add(this.textParsedBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagePickedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textParsedBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button coordinatesButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox imagePickedBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label textParsedLabel;
        private System.Windows.Forms.Label imagePickedLabel;
        private System.Windows.Forms.Label lefTopLabel;
        private System.Windows.Forms.Label lefTopLabelContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rightDownLabelContainer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button colorPickerButton;
        private System.Windows.Forms.Label colorPickerLabel;
    }
}

