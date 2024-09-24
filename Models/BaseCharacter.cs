namespace TravelersTaleCharacterCreator;


public class BaseCharacter
{
    public string Name;
    public int SkillXP;
    public BaseDiscipline Discipline;
    public BaseWren Wren;

    const int VocationalBaseValue = 2;
    
    #region Core Stats
    public int Power;
    public int Speed;
    public int Vigor;
    public int Wit;
    public int Presence;
    #endregion

    // Other Stats
    public string HealthDie;
    public int? Movement = null;
    public int AnimaStat = 0;
    public List<ProficienciesEnum> PossibleProficiencies;
    public int Vitality = 0;
    public List<string> RaceAbilities;

    #region Vocational Skills
    public int Farming = VocationalBaseValue;
    public int Science = VocationalBaseValue;
    public int Cooking = VocationalBaseValue;
    public int Medicine = VocationalBaseValue;
    public int Mechanics = VocationalBaseValue;
    public int Technology = VocationalBaseValue;
    public int Carpentry = VocationalBaseValue;
    public int Smithing = VocationalBaseValue;
    public int Mounting = VocationalBaseValue;
    public int Fishing = VocationalBaseValue;
    public int Alchemy = VocationalBaseValue;
    public int Weaving = VocationalBaseValue;
    public int Leatherworking = VocationalBaseValue;
    public int Music = VocationalBaseValue;
    public int Art = VocationalBaseValue;
    public int Botany = VocationalBaseValue;

    #endregion
    
    #region Proficiencies

    // Power
    public int Athletics = 0;
    public int Strength = 0;
    public int Intimidation = 0;
    // Speed
    public int Skulduggery = 0;
    public int Stealth = 0;
    public int Acrobatics = 0;
    // Vigor
    public int Constitution = 0;
    // Wit
    public int Navigation = 0;
    public int Survival = 0;
    public int Lore = 0;
    public int Perception = 0;
    public int Anima = 0;
    public int Deduction = 0;
    public int Streetwise = 0;
    // Presence
    public int Barter = 0;
    public int Charm = 0;
    public int Rally = 0;
    public int Cool = 0;
    public int Diplomacy = 0;

    public void InitializeProficienyStats() 
    {
        // Power
        this.Athletics = this.Power;
        this.Strength = this.Power;
        this.Intimidation = this.Power;

        // Speed
        this.Skulduggery = this.Speed;
        this.Stealth = this.Speed;
        this.Acrobatics = this.Speed;

        // Vigor
        this.Constitution = this.Vigor;

        // Wit
        this.Navigation = this.Wit;
        this.Survival = this.Wit;
        this.Lore = this.Wit;
        this.Perception = this.Wit;
        this.Anima = this.Wit;
        this.Deduction = this.Wit;
        this.Streetwise = this.Wit;

        // Presence
        this.Barter = this.Presence;
        this.Charm = this.Presence;
        this.Rally = this.Presence;
        this.Cool = this.Presence;
        this.Diplomacy = this.Presence;
    }

    #endregion
}