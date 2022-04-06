using static whatever.Print;

namespace whatever;

public class UserInfo
{
    private double deposit { get; set; }
    private double apr { get; set; }
    private double unlockRate { get; set; }
    public static void AllInfo(UserInfo myUser)
    {
        SetDeposit(myUser);
        SetApr(myUser);
        SetUnlockRate(myUser);
    }
    public static void SetDeposit(UserInfo myUser)
    {
        do
        {
            PrintAll(myUser);
            Console.Write("ENTER INITIAL DEPOSIT : ");
            myUser.deposit = double.Parse(Console.ReadLine()); 
        } while (myUser.deposit == 0 || myUser.deposit < 0);
    }

    public static void SetApr(UserInfo myUser)
    {
        do
        {
            PrintAll(myUser);
            Console.Write("ENTER INITIAL APR : ");
            myUser.apr = double.Parse(Console.ReadLine()) / 100;
        } while (myUser.apr == 0 || myUser.apr < 0);
    }

    public static void SetUnlockRate(UserInfo myUser)
    {
        do
        {
            PrintAll(myUser);
            Console.Write("ENTER INITIAL UNLOCK % : ");
            myUser.unlockRate = double.Parse(Console.ReadLine()) / 100;
        } while (myUser.unlockRate == 0 || myUser.unlockRate > 100);
    }

    public static double GetDeposit(UserInfo myUser)
    {
        return myUser.deposit;
    }
    public static double GetApr(UserInfo myUser)
    {
        return myUser.apr;
    }
    public static double GetUnlockRate(UserInfo myUser)
    {
        return myUser.unlockRate;
    }
}