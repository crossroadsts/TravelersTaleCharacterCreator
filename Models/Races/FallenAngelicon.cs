namespace TravelersTaleCharacterCreator;

public enum FallenAngeliconType
{
    Warrior,
    Guardian,
    Messenger,
}

public class FallenAngelicon : BaseCharacter
{
    public int NumberOfWings = 0;
    public FallenAngeliconType FallenAngeliconType = FallenAngeliconType.Warrior;
    
    public FallenAngelicon(FallenAngeliconType FallenAngeliconType)
    {
        this.Power = 3;
        this.Speed = 3;
        this.Vigor = 1;
        this.Wit = 1;
        this.Presence = 2;

        this.HealthDie = "1d6";
        this.Movement = null;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Survival,
            ProficienciesEnum.Skulduggery,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Charm,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Deduction,
            ProficienciesEnum.Cool,
        };

        switch(FallenAngeliconType)
        {
            case FallenAngeliconType.Warrior:
                this.Power = 3;
                this.Speed = 3;
                this.Vigor = 2;
                this.Wit = 1;
                this.Presence = 1;

                this.NumberOfWings = 1;
                break;
            case FallenAngeliconType.Guardian:
                this.Power = 3;
                this.Speed = 1;
                this.Vigor = 3;
                this.Wit = 1;
                this.Presence = 2;

                this.NumberOfWings = 5;
                break;
            case FallenAngeliconType.Messenger:
                this.Power = 2;
                this.Speed = 3;
                this.Vigor = 1;
                this.Wit = 2;
                this.Presence = 2;

                this.NumberOfWings = 3;
                break;
            default:
                break;
        }

        this.InitializeProficienyStats();
        this.Vitality = 6 + this.Vigor;
    }
}