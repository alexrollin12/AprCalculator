using System.Diagnostics;
using System;
using System.Security.Cryptography.X509Certificates;
using static whatever.Calculate;
using static whatever.AmountInfo;

namespace whatever;


public class Print
{
    public static void PrintAll(AmountInfo amount )
    {
        
            string amountDeposit = GetDeposit(amount).ToString();
            string amountUnlock = Math.Round((GetUnlockRate(amount) * 100), 2).ToString();
            string amountApr = Math.Round((GetApr(amount) * 100), 2).ToString();
            string year = YearlyIncome(amount).ToString();
            string month = MonthlyIncome(amount).ToString();
            string day = DailyIncome(amount).ToString();
            string uYear = UnlockAmount(amount, YearlyIncome(amount)).ToString();
            string uMonth = UnlockAmount(amount, MonthlyIncome(amount)).ToString();
            string uDay = UnlockAmount(amount, DailyIncome(amount)).ToString();

            Console.Clear();
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|-----------APR CALCULATOR----------");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|DEPOSIT  -->    {amountDeposit}$      ");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|APR      -->    {amountApr}%         ");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|UNLOCK % -->    {amountUnlock}%       ");
            Console.WriteLine($"|-----------------------------------");
            Console.WriteLine($"|-------------RESULTS---------------");
            Console.WriteLine($"|TOTAL  -> Year:{year}$ Month:{month}$ Day:{day}$  ");
            Console.WriteLine($"|UNLOCK -> Year:{uYear}$ Month:{uMonth}$ Day:{uDay}$  ");
            Console.WriteLine($"|-----------------------------------");
            Console.Write($"| --> ");

    }
}