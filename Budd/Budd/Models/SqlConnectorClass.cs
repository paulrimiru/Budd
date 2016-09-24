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
    public class SqlConnectorClass
    {
        public readonly SQLiteConnection myConnection;

        public SqlConnectorClass()
        {
            myConnection = DependencyService.Get<ISQLite>().GetConnection();
            myConnection.CreateTable<Unit>();
        }
        public void addInfo(Unit unit)
        {
            myConnection.Insert(new Unit
            {
                code = unit.code,
                name = unit.name,
                lecturer = unit.lecturer,
                lessonNumber = unit.lessonNumber,
                lectureRoom = unit.lectureRoom,
                day = unit.day,
                time = unit.time
            });
        }
        
        public SQLiteConnection returnConnection()
        {
            return myConnection;
        }

        public List<Unit> getMyUnits()
        {
            List<Unit> myUnitList = new List<Unit>();
            foreach(var myUnit in myConnection.Table<Unit>())
            {
                myUnitList.Add(new Unit {
                    code = myUnit.code,
                    name = myUnit.name,
                    lecturer = myUnit.lecturer,
                    lessonNumber = myUnit.lessonNumber,
                    lectureRoom = myUnit.lectureRoom,
                    day = myUnit.day,
                    time = myUnit.time
                });
            }
            return myUnitList;
        } 
    }
}
