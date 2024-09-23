namespace TravelersTaleCharacterCreator;

public class MysticTyrant : BaseDiscipline
{
    public MysticTyrant()
    {
        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Anima,
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Deduction,
        };
    }
}