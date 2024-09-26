namespace TravelersTaleCharacterCreator;

public class Vikra : BaseCharacter
{
    public Vikra()
    {
        this.Power = 2;
        this.Speed = 3;
        this.Vigor = 2;
        this.Wit = 2;
        this.Presence = 1;

        this.HealthDie = 8;
        this.Movement = 35;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Acrobatics,
            ProficienciesEnum.Strength,
            ProficienciesEnum.Stealth,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Survival,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Cool,
        };

        this.InitializeBattleSkills();
        this.InitializeProficienyStats();
    }
}