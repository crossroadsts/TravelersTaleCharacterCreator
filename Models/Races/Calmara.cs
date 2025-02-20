namespace TravelersTaleCharacterCreator;

public enum CalmaraType
{
    Balance = 1,
    Rage = 2,
    Joy = 3,
    Wisdom = 4,
}
public class Calmara : BaseCharacter
{
    public CalmaraType CalmaraType = CalmaraType.Balance;
    public Calmara(CalmaraType CalmaraType)
    {
        this.HealthDie = 8;
        this.Movement = 30;

        this.CalmaraType = CalmaraType;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Brawl,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Brawl,
            ProficienciesEnum.Dodge,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Might,
        };

        this.WeaponProficiency = WeaponTypesEnum.Fists;

        this.Race = "Calmara";

        switch(CalmaraType)
        {
            case CalmaraType.Balance:
                this.Strength = 2;
                this.Agility = 2;
                this.Vigor = 2;
                this.Wit = 2;
                this.Presence = 2;

                this.Race += " (Balance)";
                break;
            case CalmaraType.Rage:
                this.Strength = 2;
                this.Agility = 3;
                this.Vigor = 3;
                this.Wit = 2;
                this.Presence = 0;

                this.Race += " (Rage)";
                break;
            case CalmaraType.Joy:
                this.Strength = 1;
                this.Agility = 2;
                this.Vigor = 2;
                this.Wit = 2;
                this.Presence = 3;

                this.Race += " (Joy)";
                break;
            case CalmaraType.Wisdom:
                this.Strength = 2;
                this.Agility = 2;
                this.Vigor = 2;
                this.Wit = 3;
                this.Presence = 1;

                this.Race += " (Wisdom)";
                break;
            default:
                break;
        }

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}