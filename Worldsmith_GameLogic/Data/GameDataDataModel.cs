using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AWFMetadata;
using AWFMetadata.Skills;
using Newtonsoft.Json;

namespace Worldsmith.GameLogic.DataModels
{
    public class GameDataDataModel : IDataModel
    {
        public GameDataDataModel(GameData gameData)
        {
            SetGameData(gameData);
        }

        #region Properties

        private GameData gameData;
        private void SetGameData(GameData gameData)
        {
            if (this.gameData == gameData) return;

            this.gameData = gameData;

            Skills = new BindingList<SkillDefinitionDataModel>();
            foreach (SkillDefinition skill in this.gameData.skills)
            {
                Skills.Add(new SkillDefinitionDataModel(skill));
            }
        }

        public BindingList<SkillDefinitionDataModel> Skills { get; set; }

        #endregion

        #region Data Manipulation

        public void CreateNewSkill(SkillDefinition skill)
        {
            gameData.skills.Add(skill);
            Skills.Add(new SkillDefinitionDataModel(skill));
        }

        #endregion

        #region File IO

        public bool LoadFromFile(string filepath)
        {
            string json = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    json = reader.ReadToEnd();
                }
            }
            catch
            {
                return false;
            }

            GameData data = JsonConvert.DeserializeObject<GameData>(json);
            SetGameData(data);

            return true;
        }

        public bool SaveToFile(string filepath)
        {
            string json = JsonConvert.SerializeObject(gameData);
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                try
                {
                    writer.Write(json);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
