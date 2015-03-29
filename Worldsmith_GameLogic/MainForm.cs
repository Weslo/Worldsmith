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

namespace Worldsmith.GameLogic
{
    public partial class MainForm : Form
    {
        DataModels.MainFormDataModel formData = new DataModels.MainFormDataModel();
        DataModels.GameDataDataModel gameData = new DataModels.GameDataDataModel(new GameData());

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

            skillsListBox.DisplayMember = "Name";
            skillsListBox.DataSource = gameData.Skills;
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
                if (!skillNameTextBox.Enabled) skillNameTextBox.Enabled = true;
                skillNameTextBox.DataBindings.Clear();
                skillNameTextBox.DataBindings.Add("Text", gameData.Skills[selected], "Name", true, DataSourceUpdateMode.OnPropertyChanged);

                if (!skillClassRestrictionComboBox.Enabled) skillClassRestrictionComboBox.Enabled = true;
                skillClassRestrictionComboBox.DataBindings.Clear();
                skillClassRestrictionComboBox.DataBindings.Add("SelectedIndex", gameData.Skills[selected], "ClassRestriction", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        #endregion
    }
}
