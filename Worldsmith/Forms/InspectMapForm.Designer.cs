namespace Worldsmith
{
    partial class InspectMapForm
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.landmarkListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Location = new System.Drawing.Point(12, 12);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(591, 20);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "Map Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 39);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionText.Location = new System.Drawing.Point(12, 55);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(591, 102);
            this.descriptionText.TabIndex = 2;
            this.descriptionText.Text = "Map Description";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Landmarks";
            // 
            // landmarkListBox
            // 
            this.landmarkListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.landmarkListBox.FormattingEnabled = true;
            this.landmarkListBox.Location = new System.Drawing.Point(12, 180);
            this.landmarkListBox.Name = "landmarkListBox";
            this.landmarkListBox.Size = new System.Drawing.Size(149, 238);
            this.landmarkListBox.TabIndex = 4;
            this.landmarkListBox.DoubleClick += new System.EventHandler(this.landmarkListBox_DoubleClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(528, 424);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Location = new System.Drawing.Point(447, 424);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePictureBox.Location = new System.Drawing.Point(167, 180);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(436, 238);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 7;
            this.imagePictureBox.TabStop = false;
            // 
            // imageLabel
            // 
            this.imageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(167, 164);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(36, 13);
            this.imageLabel.TabIndex = 8;
            this.imageLabel.Text = "Image";
            // 
            // InspectMapForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(615, 459);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.landmarkListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InspectMapForm";
            this.Text = "Map Name";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox landmarkListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label imageLabel;
    }
}