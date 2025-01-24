namespace TravelersTaleCharacterCreator;

public enum SharkType
{
    GreatWhite = 1,
    Bull = 2,
    Tiger = 3,
    Mako = 4,
    Thresher = 5,
    Whale = 6,
    Hammerhead = 7,
    Sawtooth = 8,
    Goblin = 9,
    Megalodon = 10,
}

public class Sharkfolk : BaseCharacter
{
    public SharkType SharkType = SharkType.GreatWhite;
    public int WaterMovement = 40;

    public Sharkfolk(SharkType SharkType)
    {
        this.SharkType = SharkType;
        
        this.HealthDie = 10;
        this.Movement = 30;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Lore,
        };

        this.Race = "Sharkfolk";

        switch(SharkType)
        {
            case SharkType.GreatWhite:
                this.Strength = 3;
                this.Agility = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Great White)";
                break;
            case SharkType.Bull:
                this.Strength = 3;
                this.Agility = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Bull)";
                break;
            case SharkType.Tiger:
                this.Strength = 3;
                this.Agility = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Tiger)";
                break;
            case SharkType.Mako:
                this.Strength = 2;
                this.Agility = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Mako)";
                break;
            case SharkType.Thresher:
                this.Strength = 2;
                this.Agility = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Thresher)";
                break;
            case SharkType.Whale:
                this.Strength = 2;
                this.Agility = 1;
                this.Vigor = 2;
                this.Wit = 3;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Whale)";
                break;
            case SharkType.Hammerhead:
                this.Strength = 3;
                this.Agility = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Hammerhead)";
                break;
            case SharkType.Sawtooth:
                this.Strength = 2;
                this.Agility = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Sawtooth)";
                break;
            case SharkType.Goblin:
                this.Strength = 2;
                this.Agility = 2;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 3;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Goblin)";

                // Nightmare of the Deep
                this.Intimidation += 1;
                break;
            case SharkType.Megalodon:
                this.Strength = 3;
                this.Agility = 0;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 3;
                this.InitializeProficienyStats();
                this.PDR = this.Strength + this.Agility + this.Vigor;
                this.MDR = this.Vigor + this.Wit + this.Presence;
                this.Race += " (Megalodon)";
                break;
            default:
                break;
        }
    }
}