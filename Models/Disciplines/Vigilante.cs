namespace TravelersTaleCharacterCreator;

public class Vigilante : BaseDiscipline
{
    public Vigilante()
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