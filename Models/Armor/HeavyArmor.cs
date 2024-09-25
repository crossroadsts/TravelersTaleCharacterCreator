namespace TravelersTaleCharacterCreator;

public class HeavyArmor : BaseArmor
{
    public HeavyArmor() {
        this.DefenseRating = 6;
        this.StatReq = CoreStatsEnum.Power;
        this.StatReqValue = 7;
    }
}