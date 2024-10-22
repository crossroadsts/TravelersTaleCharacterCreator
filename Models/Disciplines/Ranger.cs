namespace TravelersTaleCharacterCreator;

public class Ranger : BaseDiscipline
{
    public Ranger()
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