using System.Diagnostics;
using System;
using System.Security.Cryptography.X509Certificates;

namespace whatever;


public class Print
{
    public static void PrintAll(double apr = 0, double unlockRate = 0, double deposit = 0, string step = "",
        double yearly = 0, double monthly = 0, double daily = 0,double unyear = 0,double unmonth = 0,double unday = 0)
    {
        string userDeposit = deposit.ToString();
        string userUnlock = Math.Round((unlockRate * 100),2).ToString();
        string userApr = Math.Round((apr * 100),2).ToString();
        string message = step;
        string year = yearly.ToString();
        string month = monthly.ToString();
        string day = daily.ToString();
        string uYear = unyear.ToString();
        string uMonth = unmonth.ToString();
        string uDay = unday.ToString();
        
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