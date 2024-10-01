namespace TravelersTaleCharacterCreator;

public class MysticRanger : BaseDiscipline
{
    public MysticRanger()
    {
        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Survival,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Barter,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Charm,
        };
    }
}