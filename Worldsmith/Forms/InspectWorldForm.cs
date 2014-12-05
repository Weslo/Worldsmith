#region File Description
/*
 * InspectWorldForm.cs
 * This class handles functionality for the Inspect World form.
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
    public partial class InspectWorldForm : Form
    {
        public bool Valid { get; set; }

        private World world;

        /// <summary>
        /// Base constructor.
        /// </summary>
        public InspectWorldForm(World world)
        {
            InitializeComponent();

            InspectWorld(world);
        }

        /// <summary>
        /// Inspects a World through the fields on this form.
        /// </summary>
        /// <param name="world">World to inspect.</param>
        public void InspectWorld(World world)
        {
            this.world = world;

            Text = this.world.Name;
            nameText.Text = this.world.Name;
            versionText.Text = this.world.Version;
            authorText.Text = this.world.Author;
            descriptionText.Text = this.world.Description;

            Valid = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ValidateForm()
        {
            Valid = false;
            ClearHighlights();

            // Check for empty fields.
            if (nameText.Text == "")
            {
                nameText.BackColor = Color.Red;
                MessageBox.Show("Empty World Name.");
                return false;
            }

            Valid = true;
            return true;
        }

        /// <summary>
        /// Apply changes made in this form to the world.
        /// </summary>
        public void ApplyChanges()
        {
            if (ValidateForm())
            {
                world.Name = nameText.Text;
                world.Version = versionText.Text;
                world.Author = authorText.Text;
                world.Description = descriptionText.Text;
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
        /// Fires when the OK button is clicked.
        /// </summary>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            if (Valid) { Close(); }
        }

        /// <summary>
        /// Fires when the open world map button is clicked.
        /// </summary>
        private void openWorldMapButton_Click(object sender, EventArgs e)
        {
            ApplicationForm.Singleton.OpenMapInNewTab(world.WorldMap);
            Close();
        }
    }
}
