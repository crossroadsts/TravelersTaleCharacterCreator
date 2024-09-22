namespace TravelersTaleCharacterCreator;

public class Shadeling : BaseCharacter
{
    public Shadeling()
    {
        this.Power = 1;
        this.Speed = 3;
        this.Vigor = 1;
        this.Wit = 2;
        this.Presence = 3;

        this.HealthDie = "1d6";
        this.Movement = 35;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Lore,
        };
    }
}