using Budd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Budd.Pages
{
    public partial class UnitsPage : ContentPage
    {
        private string code1;
        private string lecturer;
        private string name;

        public UnitsPage(string name, string code1, string lecturer)
        {
            InitializeComponent();
            this.name = name;
            this.code1 = code1;
            this.lecturer = lecturer;
            this.Title = name;

            this.Appearing += UnitsPage_Appearing;
        }

        private void UnitsPage_Appearing(object sender, EventArgs e)
        {
            course.Text = name;
            code.Text = code1;
            lecturer1.Text = lecturer;
            activityList.BindingContext = new UnitsActivitiesSql().getMyUnits(name);
        }

        private void addbutton_Clicked(object sender, EventArgs e)
        {
            UnitsActivities units = new UnitsActivities();
            units.unitName = name;
            units.name = activity.Text;
            units.time = deadline.Date.ToString();

            var addToDb = new UnitsActivitiesSql();
            addToDb.addInfo(units);
            activity.Text = "";

            activityList.BindingContext = new UnitsActivitiesSql().getMyUnits(name);
        }
    }
}
