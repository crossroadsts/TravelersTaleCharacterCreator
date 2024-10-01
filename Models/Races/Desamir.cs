namespace TravelersTaleCharacterCreator;

public class Desamir : BaseCharacter
{
    public Desamir()
    {
        this.Power = 3;
        this.Speed = 3;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 0;

        this.HealthDie = 8;
        this.Movement = 30;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Survival,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Constitution,
        };

        this.Race = "Desamir";

        this.InitializeProficienyStats();
    }
}