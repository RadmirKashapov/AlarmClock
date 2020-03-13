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
        int Id { get; set; }
        int Hours { get; set; }
        int Minutes { get; set; }

        public void WakeUp() 
        {
            Console.Beep(1000, 1500);
        }
        void Save() { }
    }
}
