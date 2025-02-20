namespace TravelersTaleCharacterCreator;

public class Shadeling : BaseCharacter
{
    public Shadeling()
    {
        this.Strength = 1;
        this.Agility = 3;
        this.Vigor = 1;
        this.Wit = 2;
        this.Presence = 3;

        this.HealthDie = 6;
        this.Movement = 35;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Stealth,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Barter,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Dodge,
            ProficienciesEnum.Alchemy,
            ProficienciesEnum.Deduction,
        };

        this.WeaponProficiency = WeaponTypesEnum.Sword;

        this.Race = "Shadeling";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}