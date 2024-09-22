namespace TravelersTaleCharacterCreator;

public class FallenAngelicon : BaseCharacter
{
    public FallenAngelicon()
    {
        this.Power = 3;
        this.Speed = 3;
        this.Vigor = 1;
        this.Wit = 1;
        this.Presence = 2;

        this.HealthDie = "1d6";
        this.Movement = null;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Survival,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Charm,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Cool,
        };
    }
}