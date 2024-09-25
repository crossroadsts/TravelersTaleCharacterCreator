namespace TravelersTaleCharacterCreator;

public class LightArmor : BaseArmor
{
    public LightArmor() {
        this.DefenseRating = 4;
        this.StatReq = CoreStatsEnum.Speed;
        this.StatReqValue = 7;
    }
}