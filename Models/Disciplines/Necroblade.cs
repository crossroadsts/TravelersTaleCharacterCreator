namespace TravelersTaleCharacterCreator;

public class Necroblade : BaseDiscipline
{
    public Necroblade()
    {
        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Athletics,
        };
    }
}