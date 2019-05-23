using  System;
using System.Threading;
namespace ASM9
{
    public class Bom
    {
        public static void Main(string[] args)
        {
            Thread Bom = new Thread(RunBomno);
            Bom.Start();
        }

        public static void RunBomno()
        {
            for (int a = 6; a >= 0; a--)
            {
                for (int i = 59; i >= 0; i--)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Console.WriteLine(""+a.ToString("D2") + ":" +i.ToString("D2"));
                    Thread.Sleep(300);
                }
            }
            Console.WriteLine("Bùm...");
            Console.WriteLine("Bom no roi nhe!!");
        }
    }
}