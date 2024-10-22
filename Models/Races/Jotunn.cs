namespace TravelersTaleCharacterCreator;

public enum JotunnType
{
    Frost = 1,
    Stone = 2,
    Fire = 3,
}

public class Jotunn : BaseCharacter
{
    public JotunnType JotunnType = JotunnType.Frost;
    
    public Jotunn(JotunnType JotunnType)
    {
        this.Power = 3;
        this.Speed = 1;
        this.Vigor = 4;
        this.Wit = 0;
        this.Presence = 2;
        
        this.HealthDie = 10;
        this.Movement = 30;

        this.JotunnType = JotunnType;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Strength,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Survival,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Cool,
        };

        this.Race = "Jotunn";

        switch(JotunnType)
        {
            case JotunnType.Frost:
                this.Race += " (Frost)";
                break;
            case JotunnType.Stone:
                this.Race += " (Stone)";
                break;
            case JotunnType.Fire:
                this.Race += " (Fire)";
                break;
            default:
                break;
        }

        this.InitializeProficienyStats();
    }
}