using System.Diagnostics;
using System;
using System.Security.Cryptography.X509Certificates;
using static whatever.Calculate;

namespace whatever;


public class Print
{
    public static void PrintAll(UserInfo myUser )
    {
        
            string userDeposit = myUser.deposit.ToString();
            string userUnlock = Math.Round((myUser.unlockRate * 100), 2).ToString();
            string userApr = Math.Round((myUser.apr * 100), 2).ToString();
            string message = "";
            string year = YearlyIncome(myUser).ToString();
            string month = MonthlyIncome(myUser).ToString();
            string day = DailyIncome(myUser).ToString();
            string uYear = UnlockAmount(myUser, YearlyIncome(myUser)).ToString();
            string uMonth = UnlockAmount(myUser, MonthlyIncome(myUser)).ToString();
            string uDay = UnlockAmount(myUser, DailyIncome(myUser)).ToString();

            Console.Clear();
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|-----------APR CALCULATOR----------");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|DEPOSIT  -->    {userDeposit}$      ");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|APR      -->    {userApr}%         ");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|UNLOCK % -->    {userUnlock}%       ");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|-------------RESULTS---------------");
            Console.WriteLine($"|TOTAL  -> Year:{year}$ Month:{month}$ Day:{day}$  ");
            Console.WriteLine($"|UNLOCK -> Year:{uYear}$ Month:{uMonth}$ Day:{uDay}$  ");
            Console.WriteLine($"|-----------------------------------");
            Console.Write($"|{message} --> ");

    }
}