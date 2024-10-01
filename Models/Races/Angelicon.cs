namespace TravelersTaleCharacterCreator;

public enum AngeliconType
{
    Warrior = 1,
    Guardian = 2,
    Messenger = 3,
}

public class Angelicon : BaseCharacter
{
    public int NumberOfWings = 0;
    public AngeliconType AngeliconType = AngeliconType.Warrior;
    
    public Angelicon(AngeliconType AngeliconType)
    {
        this.HealthDie = 6;
        this.Movement = 30;

        this.AngeliconType = AngeliconType;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Diplomacy,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Intimidation,
        };

        this.Race = "Angelicon";

        switch(AngeliconType)
        {
            case AngeliconType.Warrior:
                this.Power = 3;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 1;

                this.NumberOfWings = 2;
                this.Race += " (Warrior)";
                break;
            case AngeliconType.Guardian:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;

                this.NumberOfWings = 6;
                this.Race += " (Guardian)";
                break;
            case AngeliconType.Messenger:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 1;
                this.Wit = 2;
                this.Presence = 2;

                this.NumberOfWings = 4;
                this.Race += " (Messenger)";
                break;
            default:
                break;
        }

        this.InitializeProficienyStats();
    }
}