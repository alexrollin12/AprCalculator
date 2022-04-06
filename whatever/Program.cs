using static whatever.GetInfo;
using static whatever.Print;
using static whatever.Calculate;

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
            
        }
            
            


    }
}