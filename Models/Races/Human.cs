namespace TravelersTaleCharacterCreator;

public class Human : BaseCharacter
{
    public Human()
    {
        this.Strength = 2;
        this.Agility = 2;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 2;

        this.HealthDie = 8;
        this.Movement = 30;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Barter,
            ProficienciesEnum.Streetwise,
        };

        this.Race = "Human";

        this.InitializeProficienyStats();

        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}