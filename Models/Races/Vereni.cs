namespace TravelersTaleCharacterCreator;

public class Vereni : BaseCharacter
{
    public Vereni()
    {
        this.Strength = 1;
        this.Agility = 3;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 2;

        this.HealthDie = 6;
        this.Movement = 35;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Rally,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Perception,
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Dodge,
            ProficienciesEnum.Hunting,
        };

        this.WeaponProficiency = WeaponTypesEnum.Polearm;

        this.Race = "Vereni";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}