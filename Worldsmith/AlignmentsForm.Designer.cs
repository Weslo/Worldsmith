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
            this.factionApplyButton = new System.Windows.Forms.Button();
            this.factionDescriptionText = new System.Windows.Forms.TextBox();
            this.factionDescriptionLabel = new System.Windows.Forms.Label();
            this.factionNameText = new System.Windows.Forms.TextBox();
            this.factionNameLabel = new System.Windows.Forms.Label();
            this.factionsLabel = new System.Windows.Forms.Label();
            this.addFactionButton = new System.Windows.Forms.Button();
            this.removeFactionButton = new System.Windows.Forms.Button();
            this.factionsListBox = new System.Windows.Forms.ListBox();
            this.alignmentTabControl.SuspendLayout();
            this.racesTabControl.SuspendLayout();
            this.factionsTabPage.SuspendLayout();
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
            this.addRaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.removeRaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.factionsTabPage.Controls.Add(this.factionApplyButton);
            this.factionsTabPage.Controls.Add(this.factionDescriptionText);
            this.factionsTabPage.Controls.Add(this.factionDescriptionLabel);
            this.factionsTabPage.Controls.Add(this.factionNameText);
            this.factionsTabPage.Controls.Add(this.factionNameLabel);
            this.factionsTabPage.Controls.Add(this.factionsLabel);
            this.factionsTabPage.Controls.Add(this.addFactionButton);
            this.factionsTabPage.Controls.Add(this.removeFactionButton);
            this.factionsTabPage.Controls.Add(this.factionsListBox);
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
            this.raceApplyButton.Click += new System.EventHandler(this.raceApplyButton_Click);
            // 
            // factionApplyButton
            // 
            this.factionApplyButton.Location = new System.Drawing.Point(520, 331);
            this.factionApplyButton.Name = "factionApplyButton";
            this.factionApplyButton.Size = new System.Drawing.Size(75, 23);
            this.factionApplyButton.TabIndex = 19;
            this.factionApplyButton.Text = "Apply";
            this.factionApplyButton.UseVisualStyleBackColor = true;
            this.factionApplyButton.Click += new System.EventHandler(this.factionApplyButton_Click);
            // 
            // factionDescriptionText
            // 
            this.factionDescriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factionDescriptionText.Enabled = false;
            this.factionDescriptionText.Location = new System.Drawing.Point(136, 76);
            this.factionDescriptionText.Multiline = true;
            this.factionDescriptionText.Name = "factionDescriptionText";
            this.factionDescriptionText.Size = new System.Drawing.Size(455, 249);
            this.factionDescriptionText.TabIndex = 18;
            // 
            // factionDescriptionLabel
            // 
            this.factionDescriptionLabel.AutoSize = true;
            this.factionDescriptionLabel.Location = new System.Drawing.Point(133, 60);
            this.factionDescriptionLabel.Name = "factionDescriptionLabel";
            this.factionDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.factionDescriptionLabel.TabIndex = 17;
            this.factionDescriptionLabel.Text = "Description";
            // 
            // factionNameText
            // 
            this.factionNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factionNameText.Enabled = false;
            this.factionNameText.Location = new System.Drawing.Point(136, 37);
            this.factionNameText.Name = "factionNameText";
            this.factionNameText.Size = new System.Drawing.Size(455, 20);
            this.factionNameText.TabIndex = 16;
            // 
            // factionNameLabel
            // 
            this.factionNameLabel.AutoSize = true;
            this.factionNameLabel.Location = new System.Drawing.Point(133, 21);
            this.factionNameLabel.Name = "factionNameLabel";
            this.factionNameLabel.Size = new System.Drawing.Size(35, 13);
            this.factionNameLabel.TabIndex = 15;
            this.factionNameLabel.Text = "Name";
            // 
            // factionsLabel
            // 
            this.factionsLabel.AutoSize = true;
            this.factionsLabel.Location = new System.Drawing.Point(7, 5);
            this.factionsLabel.Name = "factionsLabel";
            this.factionsLabel.Size = new System.Drawing.Size(47, 13);
            this.factionsLabel.TabIndex = 14;
            this.factionsLabel.Text = "Factions";
            // 
            // addFactionButton
            // 
            this.addFactionButton.Location = new System.Drawing.Point(74, 304);
            this.addFactionButton.Name = "addFactionButton";
            this.addFactionButton.Size = new System.Drawing.Size(50, 50);
            this.addFactionButton.TabIndex = 13;
            this.addFactionButton.Text = "+";
            this.addFactionButton.UseVisualStyleBackColor = true;
            this.addFactionButton.Click += new System.EventHandler(this.addFactionButton_Click);
            // 
            // removeFactionButton
            // 
            this.removeFactionButton.Location = new System.Drawing.Point(10, 304);
            this.removeFactionButton.Name = "removeFactionButton";
            this.removeFactionButton.Size = new System.Drawing.Size(50, 50);
            this.removeFactionButton.TabIndex = 12;
            this.removeFactionButton.Text = "-";
            this.removeFactionButton.UseVisualStyleBackColor = true;
            this.removeFactionButton.Click += new System.EventHandler(this.removeFactionButton_Click);
            // 
            // factionsListBox
            // 
            this.factionsListBox.FormattingEnabled = true;
            this.factionsListBox.Location = new System.Drawing.Point(7, 21);
            this.factionsListBox.Name = "factionsListBox";
            this.factionsListBox.Size = new System.Drawing.Size(120, 277);
            this.factionsListBox.TabIndex = 11;
            this.factionsListBox.SelectedIndexChanged += new System.EventHandler(this.factionsListBox_SelectedIndexChanged);
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
            this.factionsTabPage.ResumeLayout(false);
            this.factionsTabPage.PerformLayout();
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
        private System.Windows.Forms.Button factionApplyButton;
        private System.Windows.Forms.TextBox factionDescriptionText;
        private System.Windows.Forms.Label factionDescriptionLabel;
        private System.Windows.Forms.TextBox factionNameText;
        private System.Windows.Forms.Label factionNameLabel;
        private System.Windows.Forms.Label factionsLabel;
        private System.Windows.Forms.Button addFactionButton;
        private System.Windows.Forms.Button removeFactionButton;
        private System.Windows.Forms.ListBox factionsListBox;
    }
}