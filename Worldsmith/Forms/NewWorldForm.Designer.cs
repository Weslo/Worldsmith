namespace Worldsmith
{
    partial class NewWorldForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseDirectoryButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryText = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.customMapNameCheckBox = new System.Windows.Forms.CheckBox();
            this.customMapNameText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.projectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "World Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(86, 45);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(280, 20);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create a new Worldsmith World project.";
            // 
            // browseDirectoryButton
            // 
            this.browseDirectoryButton.Location = new System.Drawing.Point(291, 251);
            this.browseDirectoryButton.Name = "browseDirectoryButton";
            this.browseDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.browseDirectoryButton.TabIndex = 3;
            this.browseDirectoryButton.Text = "Browse";
            this.browseDirectoryButton.UseVisualStyleBackColor = true;
            this.browseDirectoryButton.Click += new System.EventHandler(this.browseDirectoryButton_Click);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(12, 256);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(85, 13);
            this.directoryLabel.TabIndex = 4;
            this.directoryLabel.Text = "Project Directory";
            // 
            // directoryText
            // 
            this.directoryText.Enabled = false;
            this.directoryText.Location = new System.Drawing.Point(103, 253);
            this.directoryText.Name = "directoryText";
            this.directoryText.Size = new System.Drawing.Size(181, 20);
            this.directoryText.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 87);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(91, 13);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "World Description";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(15, 104);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(351, 134);
            this.descriptionText.TabIndex = 7;
            // 
            // customMapNameCheckBox
            // 
            this.customMapNameCheckBox.AutoSize = true;
            this.customMapNameCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customMapNameCheckBox.Location = new System.Drawing.Point(15, 290);
            this.customMapNameCheckBox.Name = "customMapNameCheckBox";
            this.customMapNameCheckBox.Size = new System.Drawing.Size(147, 17);
            this.customMapNameCheckBox.TabIndex = 8;
            this.customMapNameCheckBox.Text = "Custom World Map Name";
            this.customMapNameCheckBox.UseVisualStyleBackColor = true;
            this.customMapNameCheckBox.CheckedChanged += new System.EventHandler(this.customMapNameCheckBox_CheckedChanged);
            // 
            // customMapNameText
            // 
            this.customMapNameText.Enabled = false;
            this.customMapNameText.Location = new System.Drawing.Point(168, 288);
            this.customMapNameText.Name = "customMapNameText";
            this.customMapNameText.Size = new System.Drawing.Size(198, 20);
            this.customMapNameText.TabIndex = 9;
            this.customMapNameText.TextChanged += new System.EventHandler(this.customMapNameText_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(290, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(209, 341);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // projectFolderBrowserDialog
            // 
            this.projectFolderBrowserDialog.Description = "Select a folder to use as the root directory for this Worldsmith project.";
            // 
            // NewWorldForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(378, 376);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.customMapNameText);
            this.Controls.Add(this.customMapNameCheckBox);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.directoryText);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.browseDirectoryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewWorldForm";
            this.ShowInTaskbar = false;
            this.Text = "New World";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseDirectoryButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox directoryText;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.CheckBox customMapNameCheckBox;
        private System.Windows.Forms.TextBox customMapNameText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.FolderBrowserDialog projectFolderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}