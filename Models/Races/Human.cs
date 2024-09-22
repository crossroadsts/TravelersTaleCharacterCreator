namespace TravelersTaleCharacterCreator;

public class Human : BaseCharacter
{
    public Human()
    {
        this.Power = 2;
        this.Speed = 2;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 2;

        this.HealthDie = "1d8";
        this.Movement = 30;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Barter,
            ProficienciesEnum.Charm,
            ProficienciesEnum.Diplomacy,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Skulduggery,
        };

        this.InitializeProficienyStats();
        this.Vitality = 8 + this.Vigor;
    }
}