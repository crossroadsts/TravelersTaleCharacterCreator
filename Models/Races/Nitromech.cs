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
            ProficienciesEnum.Mechanics,
            ProficienciesEnum.Anima,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Mechanics,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Dodge,
        };

        this.WeaponProficiency = WeaponTypesEnum.Projectile;

        this.Race = "Nitromech";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}