namespace TravelersTaleCharacterCreator;

public class MysticVigilante : BaseDiscipline
{
    public MysticVigilante()
    {
        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Charm,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Barter,
            ProficienciesEnum.Cool,
        };
    }
}