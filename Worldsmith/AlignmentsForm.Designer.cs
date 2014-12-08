namespace Worldsmith
{
    partial class AlignmentsForm
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
            this.alignmentTabControl = new System.Windows.Forms.TabControl();
            this.racesTabControl = new System.Windows.Forms.TabPage();
            this.raceDescriptionText = new System.Windows.Forms.TextBox();
            this.raceDescriptionLabel = new System.Windows.Forms.Label();
            this.raceNameText = new System.Windows.Forms.TextBox();
            this.raceNameLabel = new System.Windows.Forms.Label();
            this.racesLabel = new System.Windows.Forms.Label();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.removeRaceButton = new System.Windows.Forms.Button();
            this.racesListBox = new System.Windows.Forms.ListBox();
            this.factionsTabPage = new System.Windows.Forms.TabPage();
            this.closeButton = new System.Windows.Forms.Button();
            this.raceApplyButton = new System.Windows.Forms.Button();
            this.alignmentTabControl.SuspendLayout();
            this.racesTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // alignmentTabControl
            // 
            this.alignmentTabControl.Controls.Add(this.racesTabControl);
            this.alignmentTabControl.Controls.Add(this.factionsTabPage);
            this.alignmentTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.alignmentTabControl.Location = new System.Drawing.Point(0, 0);
            this.alignmentTabControl.Name = "alignmentTabControl";
            this.alignmentTabControl.SelectedIndex = 0;
            this.alignmentTabControl.Size = new System.Drawing.Size(611, 385);
            this.alignmentTabControl.TabIndex = 0;
            // 
            // racesTabControl
            // 
            this.racesTabControl.Controls.Add(this.raceApplyButton);
            this.racesTabControl.Controls.Add(this.raceDescriptionText);
            this.racesTabControl.Controls.Add(this.raceDescriptionLabel);
            this.racesTabControl.Controls.Add(this.raceNameText);
            this.racesTabControl.Controls.Add(this.raceNameLabel);
            this.racesTabControl.Controls.Add(this.racesLabel);
            this.racesTabControl.Controls.Add(this.addRaceButton);
            this.racesTabControl.Controls.Add(this.removeRaceButton);
            this.racesTabControl.Controls.Add(this.racesListBox);
            this.racesTabControl.Location = new System.Drawing.Point(4, 22);
            this.racesTabControl.Name = "racesTabControl";
            this.racesTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.racesTabControl.Size = new System.Drawing.Size(603, 359);
            this.racesTabControl.TabIndex = 0;
            this.racesTabControl.Text = "Races";
            this.racesTabControl.UseVisualStyleBackColor = true;
            // 
            // raceDescriptionText
            // 
            this.raceDescriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raceDescriptionText.Enabled = false;
            this.raceDescriptionText.Location = new System.Drawing.Point(137, 74);
            this.raceDescriptionText.Multiline = true;
            this.raceDescriptionText.Name = "raceDescriptionText";
            this.raceDescriptionText.Size = new System.Drawing.Size(455, 249);
            this.raceDescriptionText.TabIndex = 9;
            // 
            // raceDescriptionLabel
            // 
            this.raceDescriptionLabel.AutoSize = true;
            this.raceDescriptionLabel.Location = new System.Drawing.Point(134, 58);
            this.raceDescriptionLabel.Name = "raceDescriptionLabel";
            this.raceDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.raceDescriptionLabel.TabIndex = 8;
            this.raceDescriptionLabel.Text = "Description";
            // 
            // raceNameText
            // 
            this.raceNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raceNameText.Enabled = false;
            this.raceNameText.Location = new System.Drawing.Point(137, 35);
            this.raceNameText.Name = "raceNameText";
            this.raceNameText.Size = new System.Drawing.Size(455, 20);
            this.raceNameText.TabIndex = 7;
            // 
            // raceNameLabel
            // 
            this.raceNameLabel.AutoSize = true;
            this.raceNameLabel.Location = new System.Drawing.Point(134, 19);
            this.raceNameLabel.Name = "raceNameLabel";
            this.raceNameLabel.Size = new System.Drawing.Size(35, 13);
            this.raceNameLabel.TabIndex = 6;
            this.raceNameLabel.Text = "Name";
            // 
            // racesLabel
            // 
            this.racesLabel.AutoSize = true;
            this.racesLabel.Location = new System.Drawing.Point(8, 3);
            this.racesLabel.Name = "racesLabel";
            this.racesLabel.Size = new System.Drawing.Size(38, 13);
            this.racesLabel.TabIndex = 5;
            this.racesLabel.Text = "Races";
            // 
            // addRaceButton
            // 
            this.addRaceButton.Location = new System.Drawing.Point(75, 302);
            this.addRaceButton.Name = "addRaceButton";
            this.addRaceButton.Size = new System.Drawing.Size(50, 50);
            this.addRaceButton.TabIndex = 2;
            this.addRaceButton.Text = "+";
            this.addRaceButton.UseVisualStyleBackColor = true;
            this.addRaceButton.Click += new System.EventHandler(this.addRaceButton_Click);
            // 
            // removeRaceButton
            // 
            this.removeRaceButton.Location = new System.Drawing.Point(11, 302);
            this.removeRaceButton.Name = "removeRaceButton";
            this.removeRaceButton.Size = new System.Drawing.Size(50, 50);
            this.removeRaceButton.TabIndex = 1;
            this.removeRaceButton.Text = "-";
            this.removeRaceButton.UseVisualStyleBackColor = true;
            this.removeRaceButton.Click += new System.EventHandler(this.removeRaceButton_Click);
            // 
            // racesListBox
            // 
            this.racesListBox.FormattingEnabled = true;
            this.racesListBox.Location = new System.Drawing.Point(8, 19);
            this.racesListBox.Name = "racesListBox";
            this.racesListBox.Size = new System.Drawing.Size(120, 277);
            this.racesListBox.TabIndex = 0;
            this.racesListBox.SelectedIndexChanged += new System.EventHandler(this.racesListBox_SelectedValueChanged);
            // 
            // factionsTabPage
            // 
            this.factionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.factionsTabPage.Name = "factionsTabPage";
            this.factionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.factionsTabPage.Size = new System.Drawing.Size(603, 359);
            this.factionsTabPage.TabIndex = 1;
            this.factionsTabPage.Text = "Factions";
            this.factionsTabPage.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(525, 391);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // raceApplyButton
            // 
            this.raceApplyButton.Location = new System.Drawing.Point(521, 329);
            this.raceApplyButton.Name = "raceApplyButton";
            this.raceApplyButton.Size = new System.Drawing.Size(75, 23);
            this.raceApplyButton.TabIndex = 10;
            this.raceApplyButton.Text = "Apply";
            this.raceApplyButton.UseVisualStyleBackColor = true;
            // 
            // AlignmentsForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 426);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.alignmentTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlignmentsForm";
            this.Text = "Alignments";
            this.alignmentTabControl.ResumeLayout(false);
            this.racesTabControl.ResumeLayout(false);
            this.racesTabControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl alignmentTabControl;
        private System.Windows.Forms.TabPage racesTabControl;
        private System.Windows.Forms.TabPage factionsTabPage;
        private System.Windows.Forms.Button addRaceButton;
        private System.Windows.Forms.Button removeRaceButton;
        private System.Windows.Forms.ListBox racesListBox;
        private System.Windows.Forms.TextBox raceNameText;
        private System.Windows.Forms.Label raceNameLabel;
        private System.Windows.Forms.Label racesLabel;
        private System.Windows.Forms.TextBox raceDescriptionText;
        private System.Windows.Forms.Label raceDescriptionLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button raceApplyButton;
    }
}