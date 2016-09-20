using Budd.Models;
using Buddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Budd.Pages
{
    public partial class AddingUnits : ContentPage
    {
        public Unit unit = new Unit();
        List<string> myDays = new List<string>();
        public AddingUnits()
        {
            InitializeComponent();
            this.Appearing += addMyDays;
        }
        private void done_Clicked(object sender, EventArgs e)
        {
            unit.code = unitCode.Text;
            unit.name = unitName.Text;
            unit.lecturer = lecturer.Text;
            unit.lectureRoom = lectureRoom.Text;
            unit.lessonNumber = lessonNumber.Text;
            unit.day = myDays[dayPicker.SelectedIndex];
            unit.time = timer.Time.ToString();

            var AddToDb = new SqlConnectorClass();
            AddToDb.addInfo(unit);
            success.Text = "Added item";
        }
        private void addMyDays(object sender, EventArgs s)
        {
            dayPicker.Items.Add("Choose a day");
            myDays.Add("Monday");
            myDays.Add("Tuesday");
            myDays.Add("Wednesday");
            myDays.Add("Thursday");
            myDays.Add("Friday");
            foreach (var days in myDays)
            {
                dayPicker.Items.Add(days);
            }
        }

    }
}
