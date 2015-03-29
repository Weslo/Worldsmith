using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWFMetadata;
using AWFMetadata.Skills;

namespace Worldsmith.GameLogic.DataModels
{
    public class SkillDefinitionDataModel : IDataModel
    {
        private SkillDefinition skill;

        public SkillDefinitionDataModel(SkillDefinition skill)
        {
            this.skill = skill;
        }

        public string Name
        {
            get { return skill.name; }
            set
            {
                if (skill.name == value) return;

                skill.name = value;
                OnPropertyChanged("Name");
            }
        }

        public int ClassRestriction
        {
            get { return (int)skill.classRestriction; }
            set
            {
                if ((int)skill.classRestriction == value) return;

                skill.classRestriction = (AdventurerClass)value;
                OnPropertyChanged("ClassRestriction");
            }
        }
    }
}
