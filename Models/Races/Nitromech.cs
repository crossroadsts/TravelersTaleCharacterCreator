namespace TravelersTaleCharacterCreator;

public class Nitromech : BaseCharacter
{
    public Nitromech()
    {
        this.Strength = 3;
        this.Agility = 2;
        this.Vigor = 1;
        this.Wit = 2;
        this.Presence = 2;

        this.HealthDie = 8;
        this.Movement = 30;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Barter,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Skulduggery,
        };

        this.Race = "Nitromech";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}