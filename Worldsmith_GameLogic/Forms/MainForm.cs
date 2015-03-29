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
        DataModels.SkillEffectDefinitionDataModel skillEffectData = new DataModels.SkillEffectDefinitionDataModel(new SkillEffectDefinition());

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

            skillNameTextBox.TextChanged += (object sender, EventArgs e) => { UpdateCurrentSkillListItemText(); };
            skillNameTextBox.DataBindings.Add("Text", skillData, "Name", true, DataSourceUpdateMode.OnValidation);
            skillClassRestrictionComboBox.DataBindings.Add("SelectedIndex", skillData, "ClassRestriction", true, DataSourceUpdateMode.OnPropertyChanged);
            skillActionCostNumericUpDown.DataBindings.Add("Value", skillData, "ActionCost", true, DataSourceUpdateMode.OnPropertyChanged);
            skillEnergyCostNumericUpDown.DataBindings.Add("Value", skillData, "EnergyCost", true, DataSourceUpdateMode.OnPropertyChanged);
            skillTargetTypeComboBox.DataBindings.Add("SelectedIndex", skillData, "TargetType", true, DataSourceUpdateMode.OnPropertyChanged);
            skillTargetTypeComboBox.Validated += (object sender, EventArgs e) => { TargetTypeChanged(); };
            skillTargetOptionsComboBox.DataBindings.Add("SelectedIndex", skillData, "TargetOptions", true, DataSourceUpdateMode.OnPropertyChanged);
            skillRangeNumericUpDown.DataBindings.Add("Value", skillData, "Range", true, DataSourceUpdateMode.OnPropertyChanged);
            skillRequiresLineOfSightCheckBox.DataBindings.Add("Checked", skillData, "RequiresLineOfSight", true, DataSourceUpdateMode.OnPropertyChanged);
            skillAttackCheckBox.DataBindings.Add("Checked", skillData, "Attack", true, DataSourceUpdateMode.OnPropertyChanged);

            skillAddEffectButton.Click += (object sender, EventArgs e) => { AddSkillEffect(); };
            skillEffectsListBox.SelectedIndexChanged += (object sender, EventArgs e) => { SkillEffectsListSelectedIndexChanged(); };

            skillEffectEffectComboBox.DataBindings.Add("SelectedIndex", skillEffectData, "Effect", true, DataSourceUpdateMode.OnPropertyChanged);
            skillEffectEffectComboBox.Validated += (object o, EventArgs e) => { UpdateCurrentSkillEffectListItemText(); };

            skillsListBox.DisplayMember = "Name";
            skillsListBox.DataSource = gameData.Skills;

            skillEffectsListBox.DisplayMember = "Display";
            skillEffectsListBox.DataSource = skillData.Effects;

            SkillsListSelectedIndexChanged();
            SkillEffectsListSelectedIndexChanged();
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

                skillEffectsListBox.DisplayMember = "Display";
                skillEffectsListBox.DataSource = skillData.Effects;

                SkillsListSelectedIndexChanged();
                SkillEffectsListSelectedIndexChanged();
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

        private void AddSkillEffect()
        {
            skillData.CreateNewEffect(new AWFMetadata.Skills.SkillEffectDefinition());
            SkillEffectsListSelectedIndexChanged();
        }

        private void SkillsListSelectedIndexChanged()
        {
            int selected = skillsListBox.SelectedIndex;
            if (selected >= 0)
            {
                skillData.Skill = gameData.Skills[selected].Skill;

                skillEffectsListBox.DataSource = skillData.Effects;
                
                if (!skillNameTextBox.Enabled) skillNameTextBox.Enabled = true;
                if (!skillClassRestrictionComboBox.Enabled) skillClassRestrictionComboBox.Enabled = true;
                if (!skillActionCostNumericUpDown.Enabled) skillActionCostNumericUpDown.Enabled = true;
                if (!skillEnergyCostNumericUpDown.Enabled) skillEnergyCostNumericUpDown.Enabled = true;
                if (!skillTargetTypeComboBox.Enabled) skillTargetTypeComboBox.Enabled = true;
                if (!skillTargetOptionsComboBox.Enabled) skillTargetOptionsComboBox.Enabled = true;
                if (!skillRangeNumericUpDown.Enabled) skillRangeNumericUpDown.Enabled = true;
                if (!skillRequiresLineOfSightCheckBox.Enabled) skillRequiresLineOfSightCheckBox.Enabled = true;
                if (!skillAttackCheckBox.Enabled) skillAttackCheckBox.Enabled = true;
                if (!skillAddEffectButton.Enabled) skillAddEffectButton.Enabled = true;
            }
        }

        private void SkillEffectsListSelectedIndexChanged()
        {
            int selected = skillEffectsListBox.SelectedIndex;
            if (selected >= 0)
            {
                skillEffectData.SkillEffect = skillData.Effects[selected].SkillEffect;

                if (!skillEffectEffectComboBox.Enabled) skillEffectEffectComboBox.Enabled = true;
            }
        }

        private void UpdateCurrentSkillListItemText()
        {
            if (gameData.Skills != null && skillsListBox.SelectedValue != null) gameData.Skills[skillsListBox.SelectedIndex].Name = skillNameTextBox.Text;
        }

        private void UpdateCurrentSkillEffectListItemText()
        {
            if (skillData.Effects != null && skillEffectsListBox.SelectedValue != null) skillData.Effects.ResetBindings();
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
