namespace Worldsmith
{
    partial class InspectWorldForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.versionText = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.TextBox();
            this.openWorldMapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Location = new System.Drawing.Point(12, 12);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(564, 20);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "World Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 113);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionText.Location = new System.Drawing.Point(12, 129);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(564, 246);
            this.descriptionText.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(501, 381);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.acceptButton.Location = new System.Drawing.Point(420, 381);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // versionText
            // 
            this.versionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionText.Location = new System.Drawing.Point(15, 51);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(561, 20);
            this.versionText.TabIndex = 1;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 35);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "Version";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 74);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author";
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(15, 90);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(561, 20);
            this.authorText.TabIndex = 2;
            // 
            // openWorldMapButton
            // 
            this.openWorldMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openWorldMapButton.Location = new System.Drawing.Point(12, 381);
            this.openWorldMapButton.Name = "openWorldMapButton";
            this.openWorldMapButton.Size = new System.Drawing.Size(103, 23);
            this.openWorldMapButton.TabIndex = 4;
            this.openWorldMapButton.Text = "Open World Map";
            this.openWorldMapButton.UseVisualStyleBackColor = true;
            this.openWorldMapButton.Click += new System.EventHandler(this.openWorldMapButton_Click);
            // 
            // InspectWorldForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(588, 416);
            this.Controls.Add(this.openWorldMapButton);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameText);
            this.Name = "InspectWorldForm";
            this.Text = "World Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox versionText;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Button openWorldMapButton;
    }
}