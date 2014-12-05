#region File Description
/*
 * InspectMapForm.cs
 * This class handles functionality for the Inspect Map form.
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
    public partial class InspectMapForm : Form
    {
        public bool Valid { get; set; }

        private Map map;

        /// <summary>
        /// Base constructor.
        /// </summary>
        /// <param name="map">Map to inspect.</param>
        public InspectMapForm(Map map)
        {
            InitializeComponent();

            InspectMap(map);
        }

        /// <summary>
        /// Inspects the fields of a given map in this form.
        /// </summary>
        /// <param name="map">Map to inspect.</param>
        public void InspectMap(Map map)
        {
            this.map = map;

            Text = this.map.Name;
            nameText.Text = this.map.Name;
            descriptionText.Text = this.map.Description;
            if (this.map.Images.Count > 0) imagePictureBox.Image = Image.FromFile(ApplicationForm.Singleton.ResourcesDirectory + map.Images["Main"]);

            landmarkListBox.Items.Clear();
            foreach (Landmark l in this.map.Landmarks.Values)
            {
                landmarkListBox.Items.Add(l.Name);
            }

            Valid = true;
        }

        /// <summary>
        /// Validate the input on this form.
        /// </summary>
        public bool ValidateForm()
        {
            Valid = false;
            ClearHighlights();

            // Check for empty fields.
            if (nameText.Text == "")
            {
                nameText.BackColor = Color.Red;
                MessageBox.Show("Empty Map Name.");
                return false;
            }

            Valid = true;
            return true;
        }

        /// <summary>
        /// Apply changes to map.
        /// </summary>
        public void ApplyChanges()
        {
            if (ValidateForm())
            {
                Text = map.Name;
                map.Name = nameText.Text;
                map.Description = descriptionText.Text;
            }
        }

        /// <summary>
        /// Clears highlights on fields.
        /// </summary>
        private void ClearHighlights()
        {
            nameText.BackColor = Color.White;
        }
        

        /// <summary>
        /// Fires when the user double clicks the landmark list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void landmarkListBox_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            int index = landmarkListBox.IndexFromPoint(me.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Landmark selected = map.Landmarks[landmarkListBox.Items[index].ToString()];
                ApplicationForm.Singleton.InspectLandmark(selected);
                InspectMap(map);
            }
        }

        /// <summary>
        /// Fires when the OK button is clicked.
        /// </summary>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            ApplyChanges();

            if (Valid) { Close(); }
        }
    }
}
