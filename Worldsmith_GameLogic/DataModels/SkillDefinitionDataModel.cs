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
            this.Skill = skill;
        }

        public SkillDefinition Skill
        {
            get { return this.skill; }
            set
            {
                if (this.skill == value) return;

                this.skill = value;
                OnPropertyChanged("Skill");
                OnPropertyChanged("Name");
                OnPropertyChanged("ClassRestriction");
                OnPropertyChanged("ActionCost");
                OnPropertyChanged("EnergyCost");
            }
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

        public int ActionCost
        {
            get { return skill.actionCost; }
            set
            {
                if (skill.actionCost == value) return;

                skill.actionCost = value;
                OnPropertyChanged("ActionCost");
            }
        }

        public int EnergyCost
        {
            get { return skill.energyCost; }
            set
            {
                if (skill.energyCost == value) return;

                skill.energyCost = value;
                OnPropertyChanged("EnergyCost");
            }
        }

        public int TargetType
        {
            get { return (int)skill.targetType; }
            set
            {
                if ((int)skill.targetType == value) return;

                skill.targetType = (SkillTargetType)value;
                OnPropertyChanged("TargetType");
            }
        }

        public int TargetOptions
        {
            get
            {
                switch (skill.targetType)
                {
                    case SkillTargetType.Entity:
                        return (int)skill.entityTargetOptions;
                    case SkillTargetType.Tile:
                        return (int)skill.tileTargetOptions;
                }
                return 0;
            }

            set
            {
                switch (skill.targetType)
                {
                    case SkillTargetType.None:
                        skill.entityTargetOptions = (EntityTargetOptions)0;
                        skill.tileTargetOptions = (TileTargetOptions)0;
                        break;
                    case SkillTargetType.Entity:
                        skill.entityTargetOptions = (EntityTargetOptions)value;
                        break;
                    case SkillTargetType.Tile:
                        skill.tileTargetOptions = (TileTargetOptions)value;
                        break;
                }
            }
        }
    }
}
