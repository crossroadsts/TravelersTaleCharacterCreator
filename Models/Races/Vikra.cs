namespace TravelersTaleCharacterCreator;

public class Vikra : BaseCharacter
{
    public Vikra()
    {
        this.Strength = 2;
        this.Agility = 3;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 1;

        this.HealthDie = 8;
        this.Movement = 35;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Cool,
        };

        this.Race = "Vikra";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}