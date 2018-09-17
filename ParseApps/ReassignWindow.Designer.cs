namespace ParseApps
{
    partial class ReassignWindow
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
            this.mousePositionLabel = new System.Windows.Forms.Label();
            this.colorPickerLabel = new System.Windows.Forms.Label();
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.mousePositionButton = new System.Windows.Forms.Button();
            this.rightDownLabelContainer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lefTopLabelContainer = new System.Windows.Forms.Label();
            this.lefTopLabel = new System.Windows.Forms.Label();
            this.coordinatesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mousePositionLabel
            // 
            this.mousePositionLabel.AutoSize = true;
            this.mousePositionLabel.Location = new System.Drawing.Point(130, 157);
            this.mousePositionLabel.Name = "mousePositionLabel";
            this.mousePositionLabel.Size = new System.Drawing.Size(0, 13);
            this.mousePositionLabel.TabIndex = 25;
            // 
            // colorPickerLabel
            // 
            this.colorPickerLabel.AutoSize = true;
            this.colorPickerLabel.Location = new System.Drawing.Point(130, 17);
            this.colorPickerLabel.Name = "colorPickerLabel";
            this.colorPickerLabel.Size = new System.Drawing.Size(66, 13);
            this.colorPickerLabel.TabIndex = 24;
            this.colorPickerLabel.Text = "Color picked";
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.Location = new System.Drawing.Point(12, 12);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(75, 23);
            this.colorPickerButton.TabIndex = 23;
            this.colorPickerButton.Text = "Pick color";
            this.colorPickerButton.UseVisualStyleBackColor = true;
            // 
            // mousePositionButton
            // 
            this.mousePositionButton.Location = new System.Drawing.Point(15, 151);
            this.mousePositionButton.Margin = new System.Windows.Forms.Padding(2);
            this.mousePositionButton.Name = "mousePositionButton";
            this.mousePositionButton.Size = new System.Drawing.Size(81, 25);
            this.mousePositionButton.TabIndex = 22;
            this.mousePositionButton.Text = "Mouse Pos.";
            this.mousePositionButton.UseVisualStyleBackColor = true;
            // 
            // rightDownLabelContainer
            // 
            this.rightDownLabelContainer.AutoSize = true;
            this.rightDownLabelContainer.Location = new System.Drawing.Point(148, 117);
            this.rightDownLabelContainer.Name = "rightDownLabelContainer";
            this.rightDownLabelContainer.Size = new System.Drawing.Size(0, 13);
            this.rightDownLabelContainer.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "RightDown Corner:";
            // 
            // lefTopLabelContainer
            // 
            this.lefTopLabelContainer.AutoSize = true;
            this.lefTopLabelContainer.Location = new System.Drawing.Point(148, 88);
            this.lefTopLabelContainer.Name = "lefTopLabelContainer";
            this.lefTopLabelContainer.Size = new System.Drawing.Size(0, 13);
            this.lefTopLabelContainer.TabIndex = 19;
            // 
            // lefTopLabel
            // 
            this.lefTopLabel.AutoSize = true;
            this.lefTopLabel.Location = new System.Drawing.Point(12, 88);
            this.lefTopLabel.Name = "lefTopLabel";
            this.lefTopLabel.Size = new System.Drawing.Size(81, 13);
            this.lefTopLabel.TabIndex = 18;
            this.lefTopLabel.Text = "LeftTop Corner:";
            // 
            // coordinatesButton
            // 
            this.coordinatesButton.Location = new System.Drawing.Point(12, 50);
            this.coordinatesButton.Margin = new System.Windows.Forms.Padding(2);
            this.coordinatesButton.Name = "coordinatesButton";
            this.coordinatesButton.Size = new System.Drawing.Size(97, 22);
            this.coordinatesButton.TabIndex = 17;
            this.coordinatesButton.Text = "Add coordinates";
            this.coordinatesButton.UseVisualStyleBackColor = true;
            // 
            // ReassignWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 192);
            this.Controls.Add(this.mousePositionLabel);
            this.Controls.Add(this.colorPickerLabel);
            this.Controls.Add(this.colorPickerButton);
            this.Controls.Add(this.mousePositionButton);
            this.Controls.Add(this.rightDownLabelContainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lefTopLabelContainer);
            this.Controls.Add(this.lefTopLabel);
            this.Controls.Add(this.coordinatesButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReassignWindow";
            this.Text = "ReassignWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mousePositionLabel;
        private System.Windows.Forms.Label colorPickerLabel;
        private System.Windows.Forms.Button colorPickerButton;
        private System.Windows.Forms.Button mousePositionButton;
        private System.Windows.Forms.Label rightDownLabelContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lefTopLabelContainer;
        private System.Windows.Forms.Label lefTopLabel;
        private System.Windows.Forms.Button coordinatesButton;
    }
}