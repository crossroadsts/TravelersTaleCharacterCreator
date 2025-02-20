namespace TravelersTaleCharacterCreator;


public class BaseCharacter
{
    public string Name;
    public string Race;
    public int SkillXP;

    // public BaseDiscipline Discipline;
    //public PersonasEnum Persona;
    //public BaseWren Wren;
    public BaseArmor Armor = null;
    
    #region Core Stats
    public int Strength;
    public int Agility;
    public int Vigor;
    public int Wit;
    public int Presence;
    #endregion

    // Other Stats
    public int PDR = 0;
    public int MDR = 0;
    public int HealthDie = 0;
    public int Movement = 0;
    public int AnimaStat = 0;
    public List<ProficienciesEnum> RaceProficiencies;
    public List<ProficienciesEnum> RaceSkills;
    public int WoundThreshold = 0;
    public FightingSkillsEnum FightingSkill = new FightingSkillsEnum();
    public WeaponTypesEnum WeaponProficiency = new WeaponTypesEnum();
    public WeaponsEnum Weapon = new WeaponsEnum();
    public List<string> RaceAbilities;
    public List<VocationalSkillsEnum> BackgroundVocSkills = new List<VocationalSkillsEnum>();
    public List<ProficienciesEnum> BackgroundProfSkills = new List<ProficienciesEnum>();
    public List<EquipmentEnum> Equipment = new List<EquipmentEnum>();

    #region Fighting Skills
    public int Grapple = 0;
    public int Shove = 0;
    public int Block = 0;
    public int Resolve = 0;
    public int Parry = 0;
    public int Disarm = 0;
    #endregion
    
    #region Proficiencies

    // Strength
    public int Brawl = 0;
    public int Climbing = 0;
    public int Might = 0;
    public int Smithing = 0;
    public int Mining = 0;
    // Agility
    public int Skulduggery = 0;
    public int Stealth = 0;
    public int Acrobatics = 0;
    public int Dodge = 0;
    public int Piloting = 0;
    public int Hunting = 0;
    // Vigor
    public int Constitution = 0;
    public int Intimidation = 0;
    public int Botany = 0;
    public int Fishing = 0;
    public int Cooking = 0;
    public int Medicine = 0;
    // Wit
    public int Anima = 0;
    public int Deduction = 0;
    public int Lore = 0;
    public int Navigation = 0;
    public int Perception = 0;
    public int Streetwise = 0;
    public int Alchemy = 0;
    public int Mechanics = 0;
    public int Taming = 0;
    // Presence
    public int Barter = 0;
    public int Charm = 0;
    public int Cool = 0;
    public int Diplomacy = 0;
    public int Performance = 0;
    public int Rally = 0;
    public int Enchanting = 0;
    public int RuneCrafting = 0;

    public void InitializeProficienyStats() 
    {
        // Strength
        this.Brawl = this.Strength;
        this.Climbing = this.Strength;
        this.Might = this.Strength;
        this.Smithing = this.Strength;
        this.Mining = this.Strength;

        // Agility
        this.Skulduggery = this.Agility;
        this.Stealth = this.Agility;
        this.Acrobatics = this.Agility;
        this.Dodge = this.Agility;
        this.Piloting = this.Agility;
        this.Hunting = this.Agility;

        // Vigor
        this.Constitution = this.Vigor;
        this.Intimidation = this.Vigor;
        this.Botany = this.Vigor;
        this.Fishing = this.Vigor;
        this.Cooking = this.Vigor;
        this.Medicine = this.Vigor;

        // Wit
        this.Anima = this.Wit;
        this.Deduction = this.Wit;
        this.Lore = this.Wit;
        this.Navigation = this.Wit;
        this.Perception = this.Wit;
        this.Streetwise = this.Wit;
        this.Mechanics = this.Wit;
        this.Alchemy = this.Wit;
        this.Taming = this.Wit;

        // Presence
        this.Barter = this.Presence;
        this.Charm = this.Presence;
        this.Enchanting = this.Presence;
        this.Cool = this.Presence;
        this.Diplomacy = this.Presence;
        this.Performance = this.Presence;
        this.Rally = this.Presence;
        this.RuneCrafting = this.Presence;

        // Fighting Skills
        this.Grapple = this.Strength;
        this.Shove = this.Strength;
        this.Block = this.Strength;
        this.Resolve = this.Vigor;
        this.Parry = this.Strength >= this.Agility ? this.Strength : this.Agility;
        this.Disarm = this.Strength >= this.Agility ? this.Strength : this.Agility;
    }

    #endregion
}