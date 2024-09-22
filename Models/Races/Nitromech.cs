namespace TravelersTaleCharacterCreator;

public class Nitromech : BaseCharacter
{
    public Nitromech()
    {
        this.Power = 3;
        this.Speed = 2;
        this.Vigor = 1;
        this.Wit = 2;
        this.Presence = 2;

        this.HealthDie = "1d8";
        this.Movement = 30;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Barter,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Acrobatics,
        };
    }
}