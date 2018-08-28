namespace ParseApps
{
    partial class MainParseApps
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.coordinatesButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lefTopLabel = new System.Windows.Forms.Label();
            this.lefTopLabelContainer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rightDownLabelContainer = new System.Windows.Forms.Label();
            this.mousePositionButton = new System.Windows.Forms.Button();
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.colorPickerLabel = new System.Windows.Forms.Label();
            this.mousePositionLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // coordinatesButton
            // 
            this.coordinatesButton.Location = new System.Drawing.Point(37, 59);
            this.coordinatesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coordinatesButton.Name = "coordinatesButton";
            this.coordinatesButton.Size = new System.Drawing.Size(129, 27);
            this.coordinatesButton.TabIndex = 4;
            this.coordinatesButton.Text = "Add coordinates";
            this.coordinatesButton.UseVisualStyleBackColor = true;
            this.coordinatesButton.Click += new System.EventHandler(this.CoordinatesButton_Click);
            this.coordinatesButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoordinatesButton_KeyDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // lefTopLabel
            // 
            this.lefTopLabel.AutoSize = true;
            this.lefTopLabel.Location = new System.Drawing.Point(37, 107);
            this.lefTopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lefTopLabel.Name = "lefTopLabel";
            this.lefTopLabel.Size = new System.Drawing.Size(108, 17);
            this.lefTopLabel.TabIndex = 9;
            this.lefTopLabel.Text = "LeftTop Corner:";
            // 
            // lefTopLabelContainer
            // 
            this.lefTopLabelContainer.AutoSize = true;
            this.lefTopLabelContainer.Location = new System.Drawing.Point(219, 107);
            this.lefTopLabelContainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lefTopLabelContainer.Name = "lefTopLabelContainer";
            this.lefTopLabelContainer.Size = new System.Drawing.Size(0, 17);
            this.lefTopLabelContainer.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "RightDown Corner:";
            // 
            // rightDownLabelContainer
            // 
            this.rightDownLabelContainer.AutoSize = true;
            this.rightDownLabelContainer.Location = new System.Drawing.Point(219, 143);
            this.rightDownLabelContainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightDownLabelContainer.Name = "rightDownLabelContainer";
            this.rightDownLabelContainer.Size = new System.Drawing.Size(0, 17);
            this.rightDownLabelContainer.TabIndex = 12;
            // 
            // mousePositionButton
            // 
            this.mousePositionButton.Location = new System.Drawing.Point(37, 194);
            this.mousePositionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mousePositionButton.Name = "mousePositionButton";
            this.mousePositionButton.Size = new System.Drawing.Size(108, 31);
            this.mousePositionButton.TabIndex = 13;
            this.mousePositionButton.Text = "Mouse Pos.";
            this.mousePositionButton.UseVisualStyleBackColor = true;
            this.mousePositionButton.Click += new System.EventHandler(this.Button2_Click);
            this.mousePositionButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoordinatesButton_KeyDown);
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.Location = new System.Drawing.Point(203, 58);
            this.colorPickerButton.Margin = new System.Windows.Forms.Padding(4);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(100, 28);
            this.colorPickerButton.TabIndex = 14;
            this.colorPickerButton.Text = "Pick color";
            this.colorPickerButton.UseVisualStyleBackColor = true;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click);
            this.colorPickerButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoordinatesButton_KeyDown);
            // 
            // colorPickerLabel
            // 
            this.colorPickerLabel.AutoSize = true;
            this.colorPickerLabel.Location = new System.Drawing.Point(325, 64);
            this.colorPickerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorPickerLabel.Name = "colorPickerLabel";
            this.colorPickerLabel.Size = new System.Drawing.Size(86, 17);
            this.colorPickerLabel.TabIndex = 15;
            this.colorPickerLabel.Text = "Color picked";
            // 
            // mousePositionLabel
            // 
            this.mousePositionLabel.AutoSize = true;
            this.mousePositionLabel.Location = new System.Drawing.Point(173, 202);
            this.mousePositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mousePositionLabel.Name = "mousePositionLabel";
            this.mousePositionLabel.Size = new System.Drawing.Size(0, 17);
            this.mousePositionLabel.TabIndex = 16;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Location = new System.Drawing.Point(501, 185);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 46);
            this.startButton.TabIndex = 49;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainParseApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 325);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mousePositionLabel);
            this.Controls.Add(this.colorPickerLabel);
            this.Controls.Add(this.colorPickerButton);
            this.Controls.Add(this.mousePositionButton);
            this.Controls.Add(this.rightDownLabelContainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lefTopLabelContainer);
            this.Controls.Add(this.lefTopLabel);
            this.Controls.Add(this.coordinatesButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainParseApps";
            this.Text = "ParseApps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button coordinatesButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label lefTopLabel;
        private System.Windows.Forms.Label lefTopLabelContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rightDownLabelContainer;
        private System.Windows.Forms.Button mousePositionButton;
        private System.Windows.Forms.Button colorPickerButton;
        private System.Windows.Forms.Label colorPickerLabel;
        private System.Windows.Forms.Label mousePositionLabel;
        private System.Windows.Forms.Button startButton;
    }
}

