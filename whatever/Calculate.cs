namespace whatever;

public class Calculate
{
    public static double YearlyIncome(UserInfo userInfo)
    {
        return Math.Round(userInfo.deposit * userInfo.apr,2, MidpointRounding.AwayFromZero);
    }
    public static double MonthlyIncome(UserInfo userInfo)
    {
        return Math.Round(YearlyIncome(userInfo) / 12,2, MidpointRounding.AwayFromZero);
    }
    public static double DailyIncome(UserInfo userInfo)
    {
        return Math.Round(YearlyIncome(userInfo) / 365,2, MidpointRounding.AwayFromZero);
    }
    public static double UnlockAmount(UserInfo userInfo, double income)
    {
        return Math.Round(income * userInfo.unlockRate,2) ;
    }
}