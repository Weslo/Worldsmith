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

        public enum SkillParameterOptions
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

        public enum SkillEffectApplicationTarget
        {
            None,
            Self,
            Target,
        }

        public enum SkillEffect
        {
            None,
            Move,
            Damage,
            ApplyStatusEffect,
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

            public List<SkillEffect> skillEffects = new List<SkillEffect> ();
        }

        public class SkillEffectDefinition
        {
            public SkillEffect effect = SkillEffect.None;
            public List<SkillParameterOptions> parameter = new List<SkillParameterOptions> ();
            public SkillEffectApplicationTarget target = SkillEffectApplicationTarget.None;
            public List<SkillEffectApplicationTarget> conditions = new List<SkillEffectApplicationTarget>();
        }

        public class SkillConditionDefinition
        {
            public SkillConditionClause clause = SkillConditionClause.None;
            public StatusEffect effectParameter = StatusEffect.None;
        }
    }
}
