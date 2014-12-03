#region File Description
/*
 * NewLandmarkForm.cs
 * This class handles functionality for the New Landmark creation form.
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
#endregion Using Statements

namespace Worldsmith
{
    public partial class nm : Form
    {

        #region Collected Information

        public string LandmarkName { get; private set; }
        public Color LandmarkColor { get; private set; }
        public bool Valid { get; private set; }

        #endregion Collected Information

        #region Fields

        private Map map;

        #endregion Fields

        /// <summary>
        /// Base constructor.
        /// </summary>
        public nm(Map map)
        {
            InitializeComponent();

            this.map = map;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Close();
            }
        }

        /// <summary>
        /// Validate the input in fields in this form.
        /// </summary>
        /// <returns>True if the form is valid, false otherwise.</returns>
        private bool ValidateForm()
        {
            ClearHighlights();

            // Flag valid as false until we finish.
            Valid = false;

            // Cache information.
            LandmarkName = nameText.Text;

            // Check for empty fields.
            if (LandmarkName == "")
            {
                nameText.BackColor = Color.Red;
                MessageBox.Show("Empty Landmark Name.");
                return false;
            }

            // Check for shared name.
            foreach(Landmark l in map.Landmarks.Values)
            {
                if (LandmarkName == l.Name)
                {
                    nameText.BackColor = Color.Red;
                    MessageBox.Show("There is already a Landmark on this map with that name.");
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
        }

        private void landmarkColorButton_Click(object sender, EventArgs e)
        {
            landmarkColorDialog.ShowDialog();
            LandmarkColor = landmarkColorDialog.Color;
            landmarkColorButton.BackColor = LandmarkColor;
        }
    }
}
