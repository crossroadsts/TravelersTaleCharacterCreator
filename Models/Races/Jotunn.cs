namespace TravelersTaleCharacterCreator;

public enum JotunnType
{
    Frost = 1,
    Stone = 2,
    Fire = 3,
}

public class Jotunn : BaseCharacter
{
    public JotunnType JotunnType = JotunnType.Frost;
    
    public Jotunn(JotunnType JotunnType)
    {
        this.Strength = 3;
        this.Agility = 1;
        this.Vigor = 4;
        this.Wit = 0;
        this.Presence = 2;
        
        this.HealthDie = 10;
        this.Movement = 30;

        this.JotunnType = JotunnType;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Might,
            ProficienciesEnum.Smithing,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Might,
            ProficienciesEnum.Climbing,
            ProficienciesEnum.Smithing,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Lore,
        };

        // Shields
        this.WeaponProficiency = WeaponTypesEnum.Hammer;

        this.Race = "Jotunn";

        switch(JotunnType)
        {
            case JotunnType.Frost:
                this.Race += " (Frost)";
                break;
            case JotunnType.Stone:
                this.Race += " (Stone)";
                break;
            case JotunnType.Fire:
                this.Race += " (Fire)";
                break;
            default:
                break;
        }

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}