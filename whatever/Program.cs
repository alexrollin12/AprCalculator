using static whatever.Print;
using static whatever.Calculate;
using static whatever.AmountInfo;

namespace whatever;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            AmountInfo amount = new AmountInfo();
            AllInfo(amount);
            PrintAll(amount);
            Console.Write("Again? ");
            Console.ReadLine();
        }
    }
}