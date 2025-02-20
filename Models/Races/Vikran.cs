namespace TravelersTaleCharacterCreator;

public class Vikran : BaseCharacter
{
    public Vikran()
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
            ProficienciesEnum.Diplomacy,
            ProficienciesEnum.Taming,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Botany,
            ProficienciesEnum.Taming,
            ProficienciesEnum.Diplomacy,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Charm,
        };

        // Shields
        this.WeaponProficiency = WeaponTypesEnum.Axe;

        this.Race = "Vikran";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}