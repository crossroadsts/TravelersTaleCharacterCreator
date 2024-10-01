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

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Lore,
        };

        this.Race = "Sharkfolk";

        switch(SharkType)
        {
            case SharkType.GreatWhite:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Great White)";
                break;
            case SharkType.Bull:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Bull)";
                break;
            case SharkType.Tiger:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Tiger)";
                break;
            case SharkType.Mako:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Mako)";
                break;
            case SharkType.Thresher:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Thresher)";
                break;
            case SharkType.Whale:
                this.Power = 2;
                this.Speed = 1;
                this.Vigor = 2;
                this.Wit = 3;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Whale)";
                break;
            case SharkType.Hammerhead:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Hammerhead)";
                break;
            case SharkType.Sawtooth:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                this.Race += " (Sawtooth)";
                break;
            case SharkType.Goblin:
                this.Power = 2;
                this.Speed = 2;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 3;
                this.InitializeProficienyStats();
                this.Race += " (Goblin)";

                // Nightmare of the Deep
                this.Intimidation += 1;
                break;
            case SharkType.Megalodon:
                this.Power = 3;
                this.Speed = 0;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 3;
                this.InitializeProficienyStats();
                this.Race += " (Megalodon)";
                break;
            default:
                break;
        }
    }
}