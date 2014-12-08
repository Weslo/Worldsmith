#region File Description
/*
 * AlignmentsForm.cs
 * This class handles functionality for the Alignments form.
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
    public partial class AlignmentsForm : Form
    {
        public bool Valid { get; set; }

        private World world;
        private Race selectedRace;

        /// <summary>
        /// Base constrcutor.
        /// </summary>
        /// <param name="world">World the alignment form edits.</param>
        public AlignmentsForm(World world)
        {
            InitializeComponent();

            InspectWorld(world);
        }

        /// <summary>
        /// Inspects the target world in the form fields.
        /// </summary>
        /// <param name="world">World to inspect.</param>
        public void InspectWorld(World world)
        {
            this.world = world;

            racesListBox.ClearSelected();
            racesListBox.Items.Clear();
            foreach (Race race in this.world.Races)
            {
                racesListBox.Items.Add(race.Name);
            }
        }

        /// <summary>
        /// Inspects the target race in the form fields.
        /// </summary>
        /// <param name="race">Race to inspect.</param>
        public void InspectRace(Race race)
        {
            selectedRace = race;
            if (selectedRace == null)
            {
                raceNameText.Text = "";
                raceDescriptionText.Text = "";

                raceNameText.Enabled = false;
                raceDescriptionText.Enabled = false;
            }
            else
            {
                raceNameText.Text = selectedRace.Name;
                raceDescriptionText.Text = selectedRace.Description;

                raceNameText.Enabled = true;
                raceDescriptionText.Enabled = true;
            }
        }

        /// <summary>
        /// Validates the currently selected race.
        /// </summary>
        /// <returns>True if the race is valid, false otherwise.</returns>
        public bool ValidateSelectedRace()
        {
            if (selectedRace == null) return false;



            return true;
        }

        /// <summary>
        /// Fires when the selected value is changed in the race list box.
        /// </summary>
        private void racesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = racesListBox.SelectedIndex;
            InspectRace(world.Races[index]);
        }

        /// <summary>
        /// Fires when the Add Race button is clicked.
        /// </summary>
        private void addRaceButton_Click(object sender, EventArgs e)
        {
            world.Races.Add(new Race("Race " + world.Races.Count + 1));
            InspectWorld(world);
        }

        private void removeRaceButton_Click(object sender, EventArgs e)
        {
            world.Races.Remove(selectedRace);
            InspectWorld(world);
        }
    }
}
