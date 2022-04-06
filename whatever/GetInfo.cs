using static whatever.Print;
namespace whatever;

public class GetInfo
{

    public static void AllInfo(UserInfo myUser)
    {
        GetDeposit(myUser);
        Console.WriteLine(myUser.deposit);
        GetApr(myUser);
        GetUnlockRate(myUser);
    }
    public static double GetDeposit(UserInfo myUser)
    {
        PrintAll(myUser.apr,myUser.unlockRate,myUser.deposit);
            Console.Write("ENTER INITIAL DEPOSIT : ");
            myUser.deposit = double.Parse(Console.ReadLine());
            return myUser.deposit;
    }

    public static double GetApr(UserInfo myUser)
    {
        do
        {
            PrintAll(myUser.apr,myUser.unlockRate,myUser.deposit);
            Console.Write("ENTER INITIAL APR : ");
            myUser.apr = double.Parse(Console.ReadLine()) / 100;
        } while (myUser.apr == 0);

        return myUser.apr;
    }

    public static double GetUnlockRate(UserInfo myUser)
    {
        do
        {
            PrintAll(myUser.apr,myUser.unlockRate,myUser.deposit);
            Console.Write("ENTER INITIAL UNLOCK % : ");
            myUser.unlockRate = double.Parse(Console.ReadLine()) / 100;
        } while (myUser.unlockRate == 0);

        return myUser.unlockRate;
    }
}