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

        this.RaceAbilities = new()
        {
            @"DagonScale Armor: 6 DR",
            @"Tail:
                Flat Damage: 3
                Crit #14
                Crit Flat Damage: 6
                MIT: 2
                Properties: Block, Parry, Reach
            ",
            @"Dagon Breath: Dagon Breath has 3 ways that it can be used. Dagon breath can be shot in a line, and then explodes, or it can be shot on the ground to create a wall of energy, or it can be fired in a large cone. The range of the abilities scales as you grow in your skill. This ability deals 2d4 damage. If using the line aoe ability, any enemy caught in the line or aoe of this ability will take 2d4, damage, if they are a part of both the line and the aoe they do not take damage twice. Pick which element you want your breath to be: Fire, Lightning, Ice, or Acid. (4 Anima) WREN ABILITY
                - Proficiency 1d4 
                    - Cone: 15ft 
                    - Wall: 5ft line or arch,
                    - Line AOE: Casting Range 15ft. AOE 5ft radius sphere
                - Proficiency 1d8
                    - Cone 30ft
                    - Wall 15ft
                    - Line AOE: Casting Range: 30ft. AOE 10ft radius sphere
                - Proficiency 1d12
                    - Cone 45ft
                    - Wall 30ft
                    - Line AOE: Casting Range 60ft. AOE 15ft radius sphere
            ",
            @"Damage Immunity: You have immunity to your Dagon Breath Damage Type.",
            @"Roar: As a maneuver, unleash a ferocious roar fearing all enemies within 30ft of you until the start of your next turn. (2 Anima)",
        };

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

        this.InitializeProficienyStats();
        this.Vitality = 10 + (this.Vigor / 2);
    }
}