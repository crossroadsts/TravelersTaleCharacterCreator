namespace TravelersTaleCharacterCreator;

public class MysticDeathKnight : BaseDiscipline
{
    public MysticDeathKnight()
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