using System;
using System.Collections.Generic;

namespace PomodoroTimer
{
    public partial class POMODORO
    {
        public event EventHandler<string> AddNewUserNameEvent;

        public class User
        {
            public string Name { get; private set; }

            public List<Activity> ActivityList { get; private set; } = new List<Activity>();


            public void LoadUserName(string value)
            {
                Name = value;
            }

            public void LoadActivitiesList(List<Activity> value)
            {
                foreach (var activity in value)
                {
                    ActivityList.Add(activity);
                }
            }




            
        }
    }
}
