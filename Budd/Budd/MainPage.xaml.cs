using Buddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Budd
{
    public partial class MainPage : ContentPage
    {
        public Unit unit = new Unit();
        public MainPage()
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
            var day = Days.getDay()[dayPicker.SelectedIndex];
            unit.day = day.name;
            unit.time = timer.Time.ToString();
        }
        private void addMyDays(object sender, EventArgs s)
        {
            dayPicker.Items.Add("Choose a day");

        }

    }
}
