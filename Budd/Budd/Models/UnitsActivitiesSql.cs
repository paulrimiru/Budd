using Buddy.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForms.SQLite.SQLite;

namespace Budd.Models
{
    public class UnitsActivitiesSql
    {
        public readonly SQLiteConnection myConnection;

        public UnitsActivitiesSql()
        {
            myConnection = DependencyService.Get<ISQLite>().GetConnection();
            myConnection.CreateTable<UnitsActivities>();
        }
        public void addInfo(UnitsActivities unit)
        {
            myConnection.Insert(new UnitsActivities
            {
                name = unit.name,
                unitName = unit.unitName,
                time = unit.time
            });
        }

        public SQLiteConnection returnConnection()
        {
            return myConnection;
        }

        public List<UnitsActivities> getMyUnits(string unitname)
        {
            List<UnitsActivities> unitActivitiesList = new List<UnitsActivities>();
            
            foreach (var activity in myConnection.Table<UnitsActivities>())
            {
                if (!activity.unitName.Equals("") && activity.unitName.Equals(unitname))
                {
                    unitActivitiesList.Add(new UnitsActivities
                    {
                        name = activity.name,
                        time = activity.time
                    });
                }
            }
            return unitActivitiesList;
        }
    }
}
