namespace TravelersTaleCharacterCreator;

public class MediumArmor : BaseArmor
{
    public MediumArmor() {
        this.DefenseRating = 5;
        this.StatReq = CoreStatsEnum.Power;
        this.StatReqValue = 5;
    }
}