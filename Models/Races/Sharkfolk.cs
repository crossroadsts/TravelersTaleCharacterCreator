namespace TravelersTaleCharacterCreator;

public enum SharkType
{
    GreatWhite,
    Bull,
    Tiger,
    Mako,
    Thresher,
    Whale,
    Hammerhead,
    Sawtooth,
    Goblin,
    Megalodon,
}

public class Sharkfolk : BaseCharacter
{
    public SharkType SharkType = SharkType.GreatWhite;
    public int WaterMovement = 40;

    public Sharkfolk(SharkType SharkType)
    {
        this.SharkType = SharkType;
        
        this.HealthDie = "1d10";
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

        switch(SharkType)
        {
            case SharkType.GreatWhite:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Bull:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Tiger:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Mako:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Thresher:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Whale:
                this.Power = 2;
                this.Speed = 1;
                this.Vigor = 2;
                this.Wit = 3;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Hammerhead:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Sawtooth:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 2;
                this.InitializeProficienyStats();
                break;
            case SharkType.Goblin:
                this.Power = 2;
                this.Speed = 2;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 3;
                this.InitializeProficienyStats();
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
                break;
            default:
                break;
        }

        this.Vitality = 10 + (this.Vigor / 2);
    }
}