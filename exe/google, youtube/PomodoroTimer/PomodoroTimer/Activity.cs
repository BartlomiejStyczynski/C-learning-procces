using System;

namespace PomodoroTimer
{
    public partial class POMODORO
    {
        public class Activity
        {
            public string Name { get; set; }
            public TimeSpan TimeSpent { get; set; }

            public override string ToString()
            {
                return Name + ", czas sprzedzony na zadaniu: " + TimeSpent.ToString();
            }
        }
    }
}
