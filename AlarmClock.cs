using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Media;
using System.IO;

namespace AlarmClock
{
    class AlarmClock
    {
        string Id { get; }
        string myText { get; set; }
        //TimerCallback tm = new TimerCallback(WakeUp);
        Timer timer { get; set; }
        int minutes { get; set; }
        int hours { get; set; }

        public AlarmClock(string str, int value, int hour, int minute)
        {
            Id = Guid.NewGuid().ToString();
            myText = str;
            minutes = minute;
            hours = hour;
            Save();
        }

        private int CountTime(int hour, int minute)
        {
            return 1;
        }
        private static void WakeUp(object obj)
        {
            
        }

        private static void Start()
        {

        }

        private void Save()
        {
            using (FileStream fstream = new FileStream($"{this.Id}.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                string data = $"{this.hours}:{this.minutes}/n{myText}";
                byte[] array = Encoding.Default.GetBytes(data);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
        }
    }
}
