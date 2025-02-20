namespace TravelersTaleCharacterCreator;

public class Dagon : BaseCharacter
{
    public Dagon()
    {
        this.Strength = 3;
        this.Agility = 1;
        this.Vigor = 3;
        this.Wit = 0;
        this.Presence = 3;

        this.HealthDie = 10;
        this.Movement = 30;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Might,
            ProficienciesEnum.Intimidation,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Might,
            ProficienciesEnum.Climbing,
            ProficienciesEnum.Piloting,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Constitution,
        };

        // Shields
        this.WeaponProficiency = WeaponTypesEnum.Axe;

        this.Race = "Dagon";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;

        // DagonScale Armor
        this.PDR += 2;
    }
}