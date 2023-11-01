using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Set your desired alarm using the \"HH:mm\" format: ");
        string alarm = Console.ReadLine();
        string timeNow;

        while (true)
        {
            timeNow = DateTime.Now.ToString("HH:mm");

            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine($"Your alarm is set to {alarm}");
            Console.WriteLine(timeNow);

            if (timeNow == alarm)
            {
                Console.Clear();
                Console.WriteLine($"Wake up! Time is {alarm}");
                break;
            }
        }
    }
}
