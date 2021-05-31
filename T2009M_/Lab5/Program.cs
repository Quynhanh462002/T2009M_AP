using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace T2009M_.Lab5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Set Min");
            int min = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Set Sec");
            int sec = int.Parse(Console.ReadLine() ?? string.Empty);

            while (min >= 0)
            {
                while (sec >= 0)
                {
                    Console.WriteLine(min + ":" + sec);
                    sec--;
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                    }
                }
                if (sec < 0)
                {
                    sec = 59;
                }

                min--;
            }
            Console.Write("Bumm...");
            
        }
    }
}