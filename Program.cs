using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;

namespace AlarmClock
{
    class Program
    {
        public static void UpdateTime(object sender)
        {
            var now = DateTime.Now.ToString("HH:mm:ss");
            Console.SetCursorPosition(0, 0);
            Console.Write("\r{0}", now);
            using (FileStream fstream = new FileStream("Current Time.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(now);
                fstream.Write(array, 0, array.Length);
            }
        }

        static public System.Timers.Timer Tm = new System.Timers.Timer();

        static void Tm_Tick(object sender, ElapsedEventArgs e)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("\r{0}", DateTime.Now.ToString());
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /*
            TimerCallback tm = new TimerCallback(UpdateTime);
            Timer timer = new Timer(tm, null, 0, 1000);

            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Thread.Sleep(2000);
            */

            Tm.Elapsed += new ElapsedEventHandler(Tm_Tick);
            Tm.Interval = 1000;
            Tm.Enabled = true;
            Console.ReadKey(true);

            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine();
                Console.WriteLine("Выберите опцию");
                //for (int i = 0; i < comps.Length; i++)
                //  Console.WriteLine($"{i} - {comps[i].MethodDescription()}");
            }
        }
    }
}
