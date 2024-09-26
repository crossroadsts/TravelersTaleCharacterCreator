namespace TravelersTaleCharacterCreator;

public class Crystalline : BaseCharacter
{
    public Crystalline()
    {
        this.Power = 2;
        this.Speed = 1;
        this.Vigor = 4;
        this.Wit = 3;
        this.Presence = 0;

        this.HealthDie = 12;
        this.Movement = 30;

        this.PossibleProficiencies = new() 
        {
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Athletics,
            ProficienciesEnum.Streetwise,
            ProficienciesEnum.Survival,
            ProficienciesEnum.Perception,
            ProficienciesEnum.Navigation,
            ProficienciesEnum.Deduction,
        };

        this.InitializeBattleSkills();
        this.InitializeProficienyStats();
    }
}