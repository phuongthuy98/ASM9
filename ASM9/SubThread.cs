using System;
using System.Threading;
namespace ASM9
{
    public class SubThread
    {
        public static void Main(string[] args)
        {
            Thread th = new Thread(RunSub);
            th.Start();
        }

        public static void RunSub()
        {
            
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Console.WriteLine("..." + i);
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("**Chúc mừng**");
        }
    }
}