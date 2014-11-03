#region File Description
/*
 * NewWorldForm.cs
 * This class handles functionality for the New World creation form.
 * 
 * Wes Rockholz
 * Copyright 2014 Wes Rockholz
 */
#endregion File Description

#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
#endregion Using Statements

namespace Worldsmith
{
    /// <summary>
    /// This class handles functionality for the New World creation form.
    /// </summary>
    public partial class NewWorldForm : Form
    {
        #region Collected Information
        
        public string WorldName { get; private set; }
        public string WorldDescription { get; private set; }
        public string WorldMapName { get; private set; }
        public string WorldDirectory { get; private set; }
        public bool Valid { get; private set; }

        #endregion Collected Information

        #region Fields

        private bool customMapName = false;

        #endregion Fields
        

        /// <summary>
        /// Base constructor.
        /// </summary>
        public NewWorldForm()
        {
            InitializeComponent();
            customMapName = customMapNameCheckBox.Checked;
            Valid = false;
        }

        /// <summary>
        /// Called when the text in the name box changes.
        /// </summary>
        private void nameText_TextChanged(object sender, EventArgs e)
        {
            // Cache world name.
            WorldName = nameText.Text;

            // If the map name isn't custom,
            if (!customMapName)
            {
                // Generate the name based on the world name.
                customMapNameText.Text = WorldName + " World Map";
            }
        }

        /// <summary>
        /// Called when the text in the custom map name box changes.
        /// </summary>
        private void customMapNameText_TextChanged(object sender, EventArgs e)
        {
            // Cache map name.
            WorldMapName = customMapNameText.Text;
        }

        /// <summary>
        /// Called when the checked state is changed.
        /// </summary>
        private void customMapNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Cache state.
            customMapName = customMapNameCheckBox.Checked;
            customMapNameText.Enabled = customMapName;
            
            // Fix map name text.
            if (customMapName)
            {
                customMapNameText.Text = "";
            }
            else
            {
                customMapNameText.Text = WorldName + " World Map";
            }
        }

        /// <summary>
        /// Called when the browse directory button is clicked.
        /// </summary>
        private void browseDirectoryButton_Click(object sender, EventArgs e)
        {
            projectFolderBrowserDialog.ShowDialog();
            directoryText.Text = projectFolderBrowserDialog.SelectedPath;
        }

        /// <summary>
        /// Called when the OK button is clicked.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            // Validate the form.
            if (ValidateForm())
            {
                Close();
            }
        }

        /// <summary>
        /// Validate this form before submitting.
        /// </summary>
        private bool ValidateForm()
        {
            ClearHighlights();

            // Flag valid as false until we finish.
            Valid = false;

            // Cache information.
            WorldName = nameText.Text;
            WorldDescription = descriptionText.Text;
            WorldDirectory = directoryText.Text;
            WorldMapName = customMapNameText.Text;

            // Check for empty fields.
            if (WorldName == "")
            {
                nameText.BackColor = Color.Red;
                return false;
            }
            if (WorldDescription == "")
            {
                descriptionText.BackColor = Color.Red;
                return false;
            }
            if (WorldDirectory == "")
            {
                directoryText.BackColor = Color.Red;
                return false;
            }
            if (WorldMapName == "")
            {
                customMapNameText.BackColor = Color.Red;
                return false;
            }

            // Check for invalid file name characters.
            char[] invalidFileCharacters = Path.GetInvalidFileNameChars();
            foreach (char character in invalidFileCharacters)
            {
                // If the world name contains an invalid character...
                if (WorldName.Contains(character))
                {
                    nameText.BackColor = Color.Red;
                    MessageBox.Show("World Name contains invalid character: " + character);
                    return false;
                }
                // If the map name contains an invalid character...
                if (WorldMapName.Contains(character))
                {
                    customMapNameText.BackColor = Color.Red;
                    MessageBox.Show("World Map Name contains invalid character: " + character);
                    return false;
                }
            }
            
            // Check for invalid path characters in directory path.
            char[] invalidPathCharacters = Path.GetInvalidPathChars();
            foreach (char character in invalidPathCharacters)
            {
                // If the directory path contains an invalid character...
                if (WorldDirectory.Contains(character))
                {
                    directoryText.BackColor = Color.Red;
                    MessageBox.Show("Directory Path contains invalid character: " + character);
                    return false;
                }
            }

            // All validation passed.
            Valid = true;
            return true;
        }

        /// <summary>
        /// Clears highlights on fields.
        /// </summary>
        private void ClearHighlights()
        {
            nameText.BackColor = Color.White;
            descriptionText.BackColor = Color.White;
            directoryText.BackColor = SystemColors.Control;
            if (customMapName)
            {
                customMapNameText.BackColor = Color.White;
            }
            else
            {
                customMapNameText.BackColor = SystemColors.Control;
            }
        }
    }
}
