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
        private Faction selectedFaction;

        /// <summary>
        /// Base constructor.
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

            factionsListBox.ClearSelected();
            factionsListBox.Items.Clear();
            foreach (Faction faction in this.world.Factions)
            {
                factionsListBox.Items.Add(faction.Name);
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
        /// Inspects the target faction in the form fields.
        /// </summary>
        /// <param name="faction">Faction to inspect.</param>
        public void InspectFaction(Faction faction)
        {
            selectedFaction = faction;
            if (selectedFaction == null)
            {
                factionNameText.Text = "";
                factionDescriptionText.Text = "";

                factionNameText.Enabled = false;
                factionDescriptionText.Enabled = false;
            }
            else
            {
                factionNameText.Text = selectedFaction.Name;
                factionDescriptionText.Text = selectedFaction.Description;

                factionNameText.Enabled = true;
                factionDescriptionText.Enabled = true;
            }
        }

        /// <summary>
        /// Validates the currently selected race.
        /// </summary>
        /// <returns>True if the race is valid, false otherwise.</returns>
        public bool ValidateSelectedRace()
        {
            if (selectedRace == null) return false;

            foreach (Race race in world.Races)
            {
                if (selectedRace == race) continue;

                if (selectedRace.Name == race.Name)
                {
                    MessageBox.Show("Race name is already in use.");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Validates the currently selected faction.
        /// </summary>
        /// <returns>True if the faction is valid, false otherwise.</returns>
        public bool ValidateSelectedFaction()
        {
            if (selectedFaction == null) return false;

            foreach (Faction faction in world.Factions)
            {
                if (selectedFaction == faction) continue;

                if (selectedFaction.Name == faction.Name)
                {
                    MessageBox.Show("Faction name is already in use.");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Applies changes to the selected race.
        /// </summary>
        public void ApplySelectedRace()
        {
            if (ValidateSelectedRace())
            {
                selectedRace.Name = raceNameText.Text;
                selectedRace.Description = raceDescriptionText.Text;
            }
        }

        /// <summary>
        /// Applies changes to the selected faction.
        /// </summary>
        public void ApplySelectedFaction()
        {
            if (ValidateSelectedFaction())
            {
                selectedFaction.Name = factionNameText.Text;
                selectedFaction.Description = factionDescriptionText.Text;
            }
        }

        /// <summary>
        /// Fires when the selected value is changed in the race list box.
        /// </summary>
        private void racesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = racesListBox.SelectedIndex;
            if (index == -1) InspectRace(null);
            else InspectRace(world.Races[index]);
        }

        /// <summary>
        /// Fires when the selected value is changed in the race list box.
        /// </summary>
        private void factionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = factionsListBox.SelectedIndex;
            if (index == -1) InspectFaction(null);
            else InspectFaction(world.Factions[index]);
        }

        /// <summary>
        /// Fires when the Add Race button is clicked.
        /// </summary>
        private void addRaceButton_Click(object sender, EventArgs e)
        {
            world.Races.Add(new Race("Race " + world.Races.Count + 1));
            InspectWorld(world);
        }

        /// <summary>
        /// Fires when the Remove Race button is clicked.
        /// </summary>
        private void removeRaceButton_Click(object sender, EventArgs e)
        {
            world.Races.Remove(selectedRace);
            InspectWorld(world);
        }

        /// <summary>
        /// Fires when the Race -> Apply button is clicked.
        /// </summary>
        private void raceApplyButton_Click(object sender, EventArgs e)
        {
            ApplySelectedRace();
            InspectWorld(world);
        }

        /// <summary>
        /// Fires when the Add Faction button is clicked.
        /// </summary>
        private void addFactionButton_Click(object sender, EventArgs e)
        {
            world.Factions.Add(new Faction("Faction " + world.Factions.Count + 1));
            InspectWorld(world);
        }

        /// <summary>
        /// Fires when the Remove Faction button is clicked.
        /// </summary>
        private void removeFactionButton_Click(object sender, EventArgs e)
        {
            world.Factions.Remove(selectedFaction);
            InspectWorld(world);
        }

        /// <summary>
        /// Fires when the Apply Faction button is clicked.
        /// </summary>
        private void factionApplyButton_Click(object sender, EventArgs e)
        {
            ApplySelectedFaction();
            InspectWorld(world);
        }
    }
}
