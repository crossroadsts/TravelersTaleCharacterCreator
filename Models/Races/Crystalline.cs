namespace TravelersTaleCharacterCreator;

public enum CrystallineType
{
    Diamond = 1,
    Lucent = 2,
}

public class Crystalline : BaseCharacter
{
    public CrystallineType CrystallineType = CrystallineType.Lucent;
    
    public Crystalline(CrystallineType CrystallineType)
    {
        this.Strength = 2;
        this.Agility = 1;
        this.Vigor = 4;
        this.Wit = 3;
        this.Presence = 0;

        this.HealthDie = 12;
        this.Movement = 30;

        this.CrystallineType = CrystallineType;

        this.RaceProficiencies = new() 
        {
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Navigation,
        };

        this.RaceSkills = new() 
        {
            ProficienciesEnum.RuneCrafting,
            ProficienciesEnum.Mining,
            ProficienciesEnum.Anima,
            ProficienciesEnum.Constitution,
            ProficienciesEnum.Lore,
            ProficienciesEnum.Perception,
        };

        // Shields

        this.Race = "Crystalline";

        this.InitializeProficienyStats();
        this.PDR = this.Strength + this.Agility + this.Vigor;
        this.MDR = this.Vigor + this.Wit + this.Presence;

        switch(CrystallineType)
        {
            case CrystallineType.Diamond:
                this.PDR += 2;
                break;
            default:
                break;
        }
    }
}