using static whatever.GetInfo;
using static whatever.Print;
using static whatever.Calculate;

namespace whatever;

public class Program
{
    public static void Main(string[] args)
    {
        
            UserInfo myUser = new UserInfo();
            AllInfo(myUser);
            double unlockY = UnlockAmount(myUser, YearlyIncome(myUser));
            double unlockM = UnlockAmount(myUser, MonthlyIncome(myUser));
            double unlockD = UnlockAmount(myUser, DailyIncome(myUser));
            PrintAll(myUser.apr,myUser.unlockRate,myUser.deposit,yearly:YearlyIncome(myUser),monthly:MonthlyIncome(myUser),daily:DailyIncome(myUser),unyear:unlockY,unmonth:unlockM,unday:unlockD);
            


    }
}