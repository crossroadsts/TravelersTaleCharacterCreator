namespace TravelersTaleCharacterCreator;

public class Warrior : BaseDiscipline
{
    public Warrior()
    {
        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Strength,
            ProficienciesEnum.Survival,
        };

        this.FrontlineFighter = true;
    }
}