namespace TravelersTaleCharacterCreator;

public class Crystalline : BaseCharacter
{
    public Crystalline()
    {
        this.Strength = 2;
        this.Agility = 1;
        this.Vigor = 4;
        this.Wit = 3;
        this.Presence = 0;

        this.HealthDie = 12;
        this.Movement = 30;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Deduction,
        };

        this.Race = "Crystalline";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}