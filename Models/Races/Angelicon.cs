namespace TravelersTaleCharacterCreator;

public enum AngeliconType
{
    Warrior = 1,
    Guardian = 2,
    Messenger = 3,
}

public class Angelicon : BaseCharacter
{
    public int NumberOfWings = 0;
    public AngeliconType AngeliconType = AngeliconType.Warrior;
    
    public Angelicon(AngeliconType AngeliconType)
    {
        this.HealthDie = 6;
        this.Movement = 30;

        this.AngeliconType = AngeliconType;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Lore,
            ProficienciesEnum.Anima,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.Charm,
            ProficienciesEnum.Diplomacy,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Enchanting,
            ProficienciesEnum.Dodge,
        };

        this.WeaponProficiency = WeaponTypesEnum.Mace;

        this.Race = "Angelicon";

        switch(AngeliconType)
        {
            case AngeliconType.Warrior:
                this.Strength = 3;
                this.Agility = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 1;

                this.NumberOfWings = 2;
                this.Race += " (Warrior)";
                break;
            case AngeliconType.Guardian:
                this.Strength = 3;
                this.Agility = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;

                this.NumberOfWings = 6;
                this.Race += " (Guardian)";
                break;
            case AngeliconType.Messenger:
                this.Strength = 2;
                this.Agility = 3;
                this.Vigor = 1;
                this.Wit = 2;
                this.Presence = 2;

                this.NumberOfWings = 4;
                this.Race += " (Messenger)";
                break;
            default:
                break;
        }

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;
    }
}