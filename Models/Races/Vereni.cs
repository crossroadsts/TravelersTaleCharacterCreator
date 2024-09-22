namespace TravelersTaleCharacterCreator;

public class Vereni : BaseCharacter
{
    public Vereni()
    {
        this.Power = 1;
        this.Speed = 3;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 2;

        this.HealthDie = "1d6";
        this.Movement = 35;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Survival,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Barter,
        };

        this.InitializeProficienyStats();
        this.Vitality = 6 + this.Vigor;
    }
}