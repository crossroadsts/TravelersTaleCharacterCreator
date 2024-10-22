namespace TravelersTaleCharacterCreator;

public enum CalmaraType
{
    Balance = 1,
    Rage = 2,
    Joy = 3,
    Wisdom = 4,
}
public class Calmara : BaseCharacter
{
    public CalmaraType CalmaraType = CalmaraType.Balance;
    public Calmara(CalmaraType CalmaraType)
    {
        this.HealthDie = 8;
        this.Movement = 30;

        this.CalmaraType = CalmaraType;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Constitution,
        };

        this.Race = "Calmara";

        switch(CalmaraType)
        {
            case CalmaraType.Balance:
                this.Power = 2;
                this.Speed = 2;
                this.Vigor = 2;
                this.Wit = 2;
                this.Presence = 2;

                this.Race += " (Balance)";
                break;
            case CalmaraType.Rage:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 3;
                this.Wit = 2;
                this.Presence = 0;

                this.Race += " (Rage)";
                break;
            case CalmaraType.Joy:
                this.Power = 1;
                this.Speed = 2;
                this.Vigor = 2;
                this.Wit = 2;
                this.Presence = 3;

                this.Race += " (Joy)";
                break;
            case CalmaraType.Wisdom:
                this.Power = 2;
                this.Speed = 2;
                this.Vigor = 2;
                this.Wit = 3;
                this.Presence = 1;

                this.Race += " (Wisdom)";
                break;
            default:
                break;
        }

        this.InitializeProficienyStats();
    }
}