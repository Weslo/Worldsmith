using System;
using System.ComponentModel;
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
        public SkillDefinitionDataModel(SkillDefinition skill)
        {
            this.skill = skill;
        }

        private SkillDefinition skill;
        public SkillDefinition Skill
        {
            get { return this.skill; }
            set
            {
                if (this.skill == value) return;

                Effects = new BindingList<SkillEffectDefinitionDataModel>();
                foreach (SkillEffectDefinition effect in this.skill.skillEffects)
                {
                    Effects.Add(new SkillEffectDefinitionDataModel(effect));
                }

                OnPropertyChanged("Skill");

                SkillDefinition prev = this.skill;
                this.skill = value;

                if (this.skill.name != prev.name) OnPropertyChanged("Name");
                if (this.skill.classRestriction != prev.classRestriction) OnPropertyChanged("ClassRestriction");
                if (this.skill.actionCost != prev.actionCost) OnPropertyChanged("ActionCost");
                if (this.skill.energyCost != prev.energyCost) OnPropertyChanged("EnergyCost");
                if (this.skill.targetType != prev.targetType) OnPropertyChanged("TargetType");
                if (this.skill.entityTargetOptions != prev.entityTargetOptions || this.skill.tileTargetOptions != value.tileTargetOptions) OnPropertyChanged("TargetOptions");
                if (this.skill.range != prev.range) OnPropertyChanged("Range");
                if (this.skill.requiresLineOfSight != prev.requiresLineOfSight) OnPropertyChanged("RequiresLineOfSight");

                Effects = new BindingList<SkillEffectDefinitionDataModel>();
                foreach (SkillEffectDefinition effect in this.skill.skillEffects)
                {
                    Effects.Add(new SkillEffectDefinitionDataModel(effect));
                }
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

                OnPropertyChanged("TargetOptions");
            }
        }

        public int Range
        {
            get { return skill.range; }
            set
            {
                if (skill.range == value) return;

                skill.range = value;
                OnPropertyChanged("Range");
            }
        }

        public bool RequiresLineOfSight
        {
            get { return skill.requiresLineOfSight; }
            set
            {
                if (skill.requiresLineOfSight == value) return;

                skill.requiresLineOfSight = value;
                OnPropertyChanged("RequiresLineOfSight");
            }
        }

        public bool Attack
        {
            get { return skill.attack; }
            set
            {
                if (skill.attack == value) return;

                skill.attack = value;
                OnPropertyChanged("Attack");
            }
        }

        public BindingList<SkillEffectDefinitionDataModel> Effects { get; set; }

        public void CreateNewEffect(SkillEffectDefinition effect)
        {
            skill.skillEffects.Add(effect);
            Effects.Add(new SkillEffectDefinitionDataModel(effect));
        }
    }
}
