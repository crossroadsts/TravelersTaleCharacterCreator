namespace TravelersTaleCharacterCreator;

public class Dagon : BaseCharacter
{
    public Dagon()
    {
        this.Power = 3;
        this.Speed = 1;
        this.Vigor = 3;
        this.Wit = 0;
        this.Presence = 3;

        this.HealthDie = "1d10";
        this.Movement = 30;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Strength,
            ProficienciesEnum.Intimidation,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Survival,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Cool,
            ProficienciesEnum.Rally,
            ProficienciesEnum.Perception,
        };

        this.InitializeBattleSkills();
        this.InitializeProficienyStats();

        double halfVigor = this.Vigor / 2;
        this.Vitality = 10 + (int)Math.Round(halfVigor);
    }
}