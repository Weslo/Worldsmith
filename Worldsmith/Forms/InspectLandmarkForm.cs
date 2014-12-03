﻿#region File Description
/*
 * InspectLandmarkForm.cs
 * This class handles functionality for the Inspect Landmark form.
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
    public partial class InspectLandmarkForm : Form
    {
        #region Fields

        private Map map;
        private Landmark landmark;

        #endregion Fields

        /// <summary>
        /// Base constructor.
        /// </summary>
        public InspectLandmarkForm(Map map, Landmark landmark)
        {
            InitializeComponent();

            InspectLandmark(map, landmark);
        }

        /// <summary>
        /// Initializes this form via information from landmark.
        /// </summary>
        /// <param name="landmark">Landmark this form inspects.</param>
        public void InspectLandmark(Map map, Landmark landmark)
        {
            this.map = map;
            this.landmark = landmark;

            Text = this.landmark.Name;
            nameText.Text = this.landmark.Name;
            colorButton.BackColor = this.landmark.Color;
            descriptionText.Text = this.landmark.Description;

            if (landmark.InternalMap != null)
            {
                mapCheckBox.Checked = true;
            }
        }

        /// <summary>
        /// Validate the input on this form.
        /// </summary>
        public bool Validate()
        {
            ClearHighlights();

            // Check for empty fields.
            if (nameText.Text == "")
            {
                nameText.BackColor = Color.Red;
                MessageBox.Show("Empty Landmark Name.");
                return false;
            }

            // Check for shared name.
            foreach (Landmark l in map.Landmarks.Values)
            {
                if (l == landmark) continue;
                if (nameText.Text == l.Name)
                {
                    nameText.BackColor = Color.Red;
                    MessageBox.Show("There is already a Landmark on this map with that name.");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Apply changes to landmark.
        /// </summary>
        public void ApplyChanges()
        {
            landmark.Name = nameText.Text;
            Text = landmark.Name;
            landmark.Description = descriptionText.Text;

            if (!mapCheckBox.Checked)
            {
                landmark.InternalMap = null;
            }
        }

        /// <summary>
        /// Fires when the delete button is clicked.
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            map.Landmarks.Remove(landmark.Name);
            Close();
        }
        
        /// <summary>
        /// Fires when the apply button is clicked.
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                ApplyChanges();

                Close();
            }
        }

        /// <summary>
        /// Fires when the checked state of the internal map check box is changed.
        /// </summary>
        private void mapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            openMapButton.Enabled = mapCheckBox.Checked;
        }

        /// <summary>
        /// Fires when the open map button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMapButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                ApplyChanges();
                if (landmark.InternalMap == null) landmark.InternalMap = new Map(landmark.Name);
                ApplicationForm.Singleton.OpenMapInNewTab(landmark.InternalMap);
                Close();
            }
        }
        

        /// <summary>
        /// Clears highlights on fields.
        /// </summary>
        private void ClearHighlights()
        {
            nameText.BackColor = Color.White;
        }
    }
}
