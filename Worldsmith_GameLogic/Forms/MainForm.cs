using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using AWFMetadata;
using AWFMetadata.Skills;

namespace Worldsmith.GameLogic
{
    public partial class MainForm : Form
    {
        DataModels.MainFormDataModel formData = new DataModels.MainFormDataModel();
        DataModels.GameDataDataModel gameData = new DataModels.GameDataDataModel(new GameData());
        DataModels.SkillDefinitionDataModel skillData = new DataModels.SkillDefinitionDataModel(new SkillDefinition());

        public MainForm()
        {
            this.InitializeComponent();

            // -- FORM WIDE -- //
            dataSourceTextBox.DataBindings.Add("Text", formData, "Filepath", true, DataSourceUpdateMode.OnPropertyChanged);
            newToolStripMenuItem.Click += (object sender, EventArgs e) => { SeekDataSourceToSave(true); };
            openToolStripMenuItem.Click += (object sender, EventArgs e) => { SeekDataSourceToLoad(); };
            saveToolStripMenuItem.Click += (object sender, EventArgs e) => { SeekDataSourceToSave(); };
            saveAsToolStripMenuItem.Click += (object sender, EventArgs e) => { SeekDataSourceToSave(true); };

            // -- SKILLS TAB -- //
            newActionButton.Click += (object sender, EventArgs e) => { CreateNewSkill(); };
            skillsListBox.SelectedIndexChanged += (object sender, EventArgs e) => { SkillsListSelectedIndexChanged(); };

            skillNameTextBox.TextChanged += (object sender, EventArgs e) => { UpdateCurrentListItemText(); };
            skillNameTextBox.DataBindings.Add("Text", skillData, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            skillClassRestrictionComboBox.DataBindings.Add("SelectedIndex", skillData, "ClassRestriction", true, DataSourceUpdateMode.OnPropertyChanged);
            skillActionCostNumericUpDown.DataBindings.Add("Value", skillData, "ActionCost", true, DataSourceUpdateMode.OnPropertyChanged);
            skillEnergyCostNumericUpDown.DataBindings.Add("Value", skillData, "EnergyCost", true, DataSourceUpdateMode.OnPropertyChanged);
            skillTargetTypeComboBox.DataBindings.Add("SelectedIndex", skillData, "TargetType", true, DataSourceUpdateMode.OnPropertyChanged);
            skillTargetOptionsComboBox.DataBindings.Add("SelectedIndex", skillData, "TargetOptions", true, DataSourceUpdateMode.OnPropertyChanged);

            skillsListBox.DisplayMember = "Name";
            skillsListBox.DataSource = gameData.Skills;

            skillData.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
            {
                TargetTypeChanged();
            };

            SkillsListSelectedIndexChanged();
        }
        
        #region File IO
        
        public void SeekDataSourceToLoad()
        {
            openDataSourceDialog.ShowDialog();
            formData.Filepath = openDataSourceDialog.FileName;
            if (formData.Filepath != string.Empty) LoadDataFromSource();
        }

        public void SeekDataSourceToSave(bool seekLocation = false)
        {
            if (seekLocation || formData.Filepath == string.Empty)
            {
                saveDataSourceDialog.ShowDialog();
                formData.Filepath = saveDataSourceDialog.FileName;
            }
            if (formData.Filepath != string.Empty) SaveDataToSource();
        }

        public void LoadDataFromSource()
        {
            if (gameData.LoadFromFile(formData.Filepath))
            {
                skillsListBox.DisplayMember = "Name";
                skillsListBox.DataSource = gameData.Skills;
            }
            else
            {
                MessageBox.Show("Could not read file.", formData.Filepath);
            }
        }

        public void SaveDataToSource()
        {
            if (gameData.SaveToFile(formData.Filepath))
            {

            }
            else
            {
                MessageBox.Show("Could not write to file.", formData.Filepath);
            }
        }

        #endregion

        #region Form Events

        private void CreateNewSkill()
        {
            gameData.CreateNewSkill(new AWFMetadata.Skills.SkillDefinition());
            SkillsListSelectedIndexChanged();
        }

        private void SkillsListSelectedIndexChanged()
        {
            int selected = skillsListBox.SelectedIndex;
            if (selected >= 0)
            {
                skillData.Skill = gameData.Skills[selected].Skill;
                if (!skillNameTextBox.Enabled) skillNameTextBox.Enabled = true;
                if (!skillClassRestrictionComboBox.Enabled) skillClassRestrictionComboBox.Enabled = true;
                if (!skillActionCostNumericUpDown.Enabled) skillActionCostNumericUpDown.Enabled = true;
                if (!skillEnergyCostNumericUpDown.Enabled) skillEnergyCostNumericUpDown.Enabled = true;
                if (!skillTargetTypeComboBox.Enabled) skillTargetTypeComboBox.Enabled = true;
            }
        }

        private void UpdateCurrentListItemText()
        {
            if (gameData.Skills != null && skillsListBox.SelectedValue != null) gameData.Skills[skillsListBox.SelectedIndex].Name = skillNameTextBox.Text;
        }

        private void TargetTypeChanged()
        {
            skillTargetOptionsComboBox.Items.Clear();
            skillTargetOptionsComboBox.Items.Add ("None");
            switch (skillData.Skill.targetType)
            {
                case SkillTargetType.None:
                    skillTargetOptionsComboBox.Enabled = false;
                    break;
                case SkillTargetType.Entity:
                    skillTargetOptionsComboBox.Enabled = true;
                    skillTargetOptionsComboBox.Items.Add("Any");
                    skillTargetOptionsComboBox.Items.Add("Self");
                    skillTargetOptionsComboBox.Items.Add("Ally");
                    skillTargetOptionsComboBox.Items.Add("Enemy");
                    break;
                case SkillTargetType.Tile:
                    skillTargetOptionsComboBox.Enabled = true;
                    skillTargetOptionsComboBox.Items.Add("Any");
                    skillTargetOptionsComboBox.Items.Add("Empty");
                    skillTargetOptionsComboBox.Items.Add("Occupied");
                    skillTargetOptionsComboBox.Items.Add("Path");
                    break;
            }
            skillData.TargetOptions = 0;
        }

        #endregion
    }
}
