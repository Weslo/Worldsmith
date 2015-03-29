using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWFMetadata;
using AWFMetadata.Skills;

namespace Worldsmith.GameLogic.DataModels
{
    public class SkillEffectDefinitionDataModel : IDataModel
    {

        public SkillEffectDefinitionDataModel(SkillEffectDefinition effect)
        {
            this.skillEffect = effect;
        }

        private SkillEffectDefinition skillEffect;
        public SkillEffectDefinition SkillEffect
        {
            get { return this.skillEffect; }
            set
            {
                if (this.skillEffect == value) return;

                OnPropertyChanged("SkillEffect");

                SkillEffectDefinition prev = this.skillEffect;
                this.skillEffect = value;

                if (this.skillEffect.effect != prev.effect) OnPropertyChanged("Effect");

                OnPropertyChanged("Display");
            }
        }

        public string Display
        {
            get
            {
                string final = "";

                switch (skillEffect.effect)
                {
                    case AWFMetadata.Skills.SkillEffect.None:
                        final += "Nothing";
                        break;
                    case AWFMetadata.Skills.SkillEffect.Move:
                        final += "Move to ";
                        break;
                }

                return final;
            }
        }

        public int Effect
        {
            get { return (int)skillEffect.effect; }
            set
            {
                if ((int)skillEffect.effect == value) return;

                skillEffect.effect = (SkillEffect)value;
                OnPropertyChanged("Effect");
            }
        }
    }
}
