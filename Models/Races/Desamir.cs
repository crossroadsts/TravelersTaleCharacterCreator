namespace TravelersTaleCharacterCreator;

public class Desamir : BaseCharacter
{
    public Desamir()
    {
        this.Strength = 3;
        this.Agility = 3;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 0;

        this.HealthDie = 8;
        this.Movement = 30;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Stealth,
        };

        this.Race = "Desamir";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}