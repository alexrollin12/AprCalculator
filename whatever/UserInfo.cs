using static whatever.Print;

namespace whatever;

public class AmountInfo
{
    private double deposit { get; set; }
    private double apr { get; set; }
    private double unlockRate { get; set; }
    public static void AllInfo(AmountInfo amount)
    {
        SetDeposit(amount);
        SetApr(amount);
        SetUnlockRate(amount);
    }
    public static void SetDeposit(AmountInfo amount)
    {
        do
        {
            PrintAll(amount);
            Console.Write("ENTER INITIAL DEPOSIT : ");
            amount.deposit = double.Parse(Console.ReadLine()); 
        } while (amount.deposit <= 0);
    }

    public static void SetApr(AmountInfo amount)
    {
        do
        {
            PrintAll(amount);
            Console.Write("ENTER INITIAL APR : ");
            amount.apr = double.Parse(Console.ReadLine()) / 100;
        } while (amount.apr <= 0);
    }

    public static void SetUnlockRate(AmountInfo amount)
    {
        do
        {
            PrintAll(amount);
            Console.Write("ENTER INITIAL UNLOCK % : ");
            amount.unlockRate = double.Parse(Console.ReadLine()) / 100;
        } while (amount.unlockRate <= 0 || amount.unlockRate > 100);
    }

    public static double GetDeposit(AmountInfo amount)
    {
        return amount.deposit;
    }
    public static double GetApr(AmountInfo amount)
    {
        return amount.apr;
    }
    public static double GetUnlockRate(AmountInfo amount)
    {
        return amount.unlockRate;
    }
    
}