using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{

    public partial class POMODORO : Form
    {
        public POMODORO()
        {
            InitializeComponent();
            LoadUserData();
        }


        public void LoadUserData()
        {
            Activity code = new Activity() { Name = "codding", TimeSpent = TimeSpan.FromSeconds(0)};
            Activity sprzatanie = new Activity() { Name = "sprzatanie", TimeSpent = TimeSpan.FromSeconds(0) };
            Activity gotowanie = new Activity() { Name = "gotowanie ", TimeSpent = TimeSpan.FromSeconds(0) };
            Activity odkurzanie = new Activity() { Name = "odkurzanie", TimeSpent = TimeSpan.FromSeconds(0) };



            List<Activity> BartekActivities = new List<Activity>();

            BartekActivities.Add(code);
            BartekActivities.Add(sprzatanie);
            BartekActivities.Add(gotowanie);
            BartekActivities.Add(odkurzanie);

            User bartek = new User();

            bartek.LoadActivitiesList(BartekActivities);

            foreach (var activity in bartek.ActivityList)
            {
                activitiesList.Items.Add(activity.ToString());
            }

            
    
        }

        public void WireUpApp()
        {
           
        }



        private void startStop_Click(object sender, EventArgs e)
        {

        }

        private void FirstPartDoneCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            EnterNewUserWindow newUserNameWindow = new EnterNewUserWindow();

            newUserNameWindow.Show();
            newUserNameWindow.NewUserAddedEvent += NewUserNameWindow_NewUserAddedEvent;



        }

        private void NewUserNameWindow_NewUserAddedEvent(object sender, string e)
        {
            User newUser = new User();
            newUser.LoadUserName(e);
            newUser.LoadActivitiesList(new List<Activity>());
            UsersList.Items.Add(newUser);
            UsersList.DisplayMember = "Name";
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are six steps in the original technique:\n" +
                "Decide on the task to be done.\n" +
                "Set the pomodoro timer (traditionally to 25 minutes).\n" +
                "Work on the task.\n" +
                "End work when the timer rings and put a checkmark on a piece of paper.\n" +
                "If you have fewer than four checkmarks, take a short break (3–5 minutes) and then return to step 2; otherwise continue to step 6.\n" +
                "After four pomodoros, take a longer break (15–30 minutes), reset your checkmark count to zero, then go to step 1.\n"
                );

        }

        private void activitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddActivityButton_Click(object sender, EventArgs e)
        {
            
            ListBox box = new ListBox();
            Activity newActivity = new Activity();
            newActivity.TimeSpent = TimeSpan.FromMilliseconds(0);
            String selectedValue = newActivity.Name;

            activitiesList.Items.Add(newActivity);
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {

            foreach (var item in UsersList.CheckedItems.OfType<User>().ToList())
            {
                UsersList.Items.Remove(item);
            }
            //1 line cone
            //List_Frente.CheckedItems.OfType<string>().ToList().ForEach(List_Frente.Items.Remove);
        }

        private void DeleteActivityButton_Click(object sender, EventArgs e)
        {
            foreach (var item in activitiesList.CheckedItems.OfType<Activity>().ToList())
            {
                activitiesList.Items.Remove(item);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
