namespace TravelersTaleCharacterCreator;

public class BaseCharacter
{
    public string Name;
    
    // Core Stats
    public int Power;
    public int Speed;
    public int Vigor;
    public int Wit;
    public int Presence;

    // Other Stats
    public string HealthDie;
    public int? Movement = null;
    public List<ProficienciesEnum> PossibleProficiencies;
    
    // Proficiencies
    public int? Athletics = null;
    public int? Strength = null;
    public int? Intimidation = null;
    public int? Skulduggery = null;
    public int? Stealth = null;
    public int? Acrobatics = null;
    public int? Constitution = null;
    public int? Navigation = null;
    public int? Survival = null;
    public int? Lore = null;
    public int? Perception = null;
    public int? Anima = null;
    public int? Deduction = null;
    public int? Streetwise = null;
    public int? Barter = null;
    public int? Charm = null;
    public int? Rally = null;
    public int? Cool = null;
    public int? Diplomacy = null;
}