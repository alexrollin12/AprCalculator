using static whatever.Print;
using static whatever.Calculate;
using static whatever.UserInfo;

namespace whatever;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            UserInfo myUser = new UserInfo();
            AllInfo(myUser);
            PrintAll(myUser);
            Console.Write("\nAgain? ");
            Console.ReadLine();

        }
    }
}