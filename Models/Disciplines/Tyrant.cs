namespace TravelersTaleCharacterCreator;

public class Tyrant : BaseDiscipline
{
    public Tyrant()
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