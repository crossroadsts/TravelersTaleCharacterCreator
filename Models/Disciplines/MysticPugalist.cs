namespace TravelersTaleCharacterCreator;

public class MysticPugalist : BaseDiscipline
{
    public MysticPugalist()
    {
        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Strength,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Deduction,
        };

        this.FrontlineFighter = true;
    }
}