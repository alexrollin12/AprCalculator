using static whatever.AmountInfo;

namespace whatever;

public class Calculate
{
    public static double YearlyIncome(AmountInfo amount)
    {
        return Math.Round(GetDeposit(amount) * GetApr(amount),2, MidpointRounding.AwayFromZero);
    }
    public static double MonthlyIncome(AmountInfo amount)
    {
        return Math.Round(YearlyIncome(amount) / 12,2, MidpointRounding.AwayFromZero);
    }
    public static double DailyIncome(AmountInfo amount)
    {
        return Math.Round(YearlyIncome(amount) / 365,2, MidpointRounding.AwayFromZero);
    }
    public static double UnlockAmount(AmountInfo amount, double income)
    {
        return Math.Round(income * GetUnlockRate(amount),2) ;
    }
}