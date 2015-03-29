using System.Collections.Generic;

namespace AWFMetadata
{
    public enum AdventurerClass
    {
        None,
        Warrior,
        Rogue,
        Mage,
        Cleric,
    }

    public class GameData
    {
        public List<Skills.SkillDefinition> skills = new List<Skills.SkillDefinition>();
    }

    namespace Skills
    {
        public enum SkillTargetType
        {
            None,
            Entity,
            Tile
        }

        public enum EntityTargetOptions
        {
            None,
            Any,
            Self,
            Ally,
            Enemy,
        }

        public enum TileTargetOptions
        {
            None,
            Any,
            Empty,
            Occupied,
            Path,
        }

        public enum SkillIntegerParameterOptions
        {
            None,

            Strength,
            Dexterity,
            Intelligence,

            MovementSpeed,

            HealthRemaining,
            HealthMissing,
            ArmorRemaining,
            ArmorMissing,
            EnergyRemaining,
            EnergyMissing,

            AttackDamage,
            EnergyCost,
            DistanceToTarget,
        }

        public enum SkillEntityParameterOptions
        {
            None,
            Self,
            Target,
        }

        public enum SkillTileParameterOptions
        {
            None,
            TargetTile,
            TargetEntityPosition,
            SourceEntityPosition,
        }

        public enum SkillEffect
        {
            None,
            Move,
            Damage,
            ApplyStatusEffect,
            RemoveStatusEffect,
            Cleanse,
        }

        public enum StatusEffect
        {
            None,

            BonusDamage,
            BonusAccuracy,
            BonusEnergy,
            BonusActions,
            BonusArmor,
            BonusEvasion,

            Burn,
            Bleed,
            Stun,
            Freeze,
            Knockdown,
            Shock,
            Snare,
            Silence,
            Blind,
            Cripple,
            DeepWound,
            Poison,
        }

        public enum SkillConditionClause
        {
            None,
            SourceHasEffect,
            SourceDoesNotHaveEffect,
            TargetHasEffect,
            TargetDoesNotHaveEffect,
            AttackHits,
        }

        public enum SkillConditionClauseRequirement
        {
            None,
            MustHave,
            MustHaveOneOf,
        }

        public class SkillDefinition
        {
            public int id = 0;
            public string name = "Unnamed Skill";

            public AdventurerClass classRestriction = AdventurerClass.None;

            public int actionCost = 0;
            public int energyCost = 0;

            public SkillTargetType targetType = SkillTargetType.None;
            public EntityTargetOptions entityTargetOptions = EntityTargetOptions.None;
            public TileTargetOptions tileTargetOptions = TileTargetOptions.None;
            public int range = int.MaxValue;
            public bool requiresLineOfSight = false;

            public bool attack = false;

            public List<SkillEffectDefinition> skillEffects = new List<SkillEffectDefinition>();
        }

        public class SkillEffectDefinition
        {
            public SkillEffect effect = SkillEffect.None;
            public List<SkillIntegerParameterOptions> integerParameterOptions = new List<SkillIntegerParameterOptions> ();
            public SkillEntityParameterOptions entityTarget = SkillEntityParameterOptions.None;
            public SkillTileParameterOptions tileTarget = SkillTileParameterOptions.None;
            public List<SkillConditionDefinition> conditions = new List<SkillConditionDefinition>();
        }

        public class SkillConditionDefinition
        {
            public SkillConditionClauseRequirement requirement = SkillConditionClauseRequirement.None;
            public SkillConditionClause clause = SkillConditionClause.None;
            public StatusEffect effectParameter = StatusEffect.None;
        }
    }
}
