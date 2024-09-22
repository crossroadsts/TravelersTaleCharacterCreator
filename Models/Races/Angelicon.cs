namespace TravelersTaleCharacterCreator;

public class Angelicon : BaseCharacter
{
    public Angelicon()
    {
        this.Power = 3;
        this.Speed = 3;
        this.Vigor = 1;
        this.Wit = 1;
        this.Presence = 2;

        this.HealthDie = "1d6";
        this.Movement = null;

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
    }
}