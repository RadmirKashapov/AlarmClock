using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Media;

namespace AlarmClock
{
    class AlarmClock
    {
        string myText { get; set; }
        //TimerCallback tm = new TimerCallback(WakeUp);
        Timer timer { get; set; }
        int minutes { get; set; }
        int hours { get; set; }

        public AlarmClock(string str, int value, int hour, int minute)
        { 
            myText = str;
            minutes = minute;
            hours = hour;
        }

        private int CountTime(int hour, int minute)
        {

        }
        private static void WakeUp(object obj)
        {
            var sp = new SoundPlayer("F:\\1.wav");
        }
    }
}
