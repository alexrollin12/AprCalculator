using static whatever.Print;
namespace whatever;

public class GetInfo
{

    public static void AllInfo(UserInfo myUser)
    {
        GetDeposit(myUser);
        GetApr(myUser);
        GetUnlockRate(myUser);
    }
    public static void GetDeposit(UserInfo myUser)
    {
        PrintAll(myUser);
            Console.Write("ENTER INITIAL DEPOSIT : ");
            myUser.deposit = double.Parse(Console.ReadLine());
    }

    public static void GetApr(UserInfo myUser)
    {
        do
        {
            PrintAll(myUser);
            Console.Write("ENTER INITIAL APR : ");
            myUser.apr = double.Parse(Console.ReadLine()) / 100;
        } while (myUser.apr == 0);
    }

    public static void GetUnlockRate(UserInfo myUser)
    {
        do
        {
            PrintAll(myUser);
            Console.Write("ENTER INITIAL UNLOCK % : ");
            myUser.unlockRate = double.Parse(Console.ReadLine()) / 100;
        } while (myUser.unlockRate == 0);
    }
}