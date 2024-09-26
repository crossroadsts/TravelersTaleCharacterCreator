namespace TravelersTaleCharacterCreator;

public class MysticWarrior : BaseDiscipline
{
    public MysticWarrior()
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