using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buddy.Models
{
   public class Days
    {
        private static List<Days> myDays;
        public Days()
        {
            myDays = new List<Days>();
            myDays.Add(new Days
            {
                name = "monday"
            });

            myDays.Add(new Days
            {
                name = "tuesday"
            });

            myDays.Add(new Days
            {
                name = "wednesday"
            });

            myDays.Add(new Days
            {
                name = "thursday"
            });

            myDays.Add(new Days
            {
                name = "friday"
            });
        }
        public String name { get; set; }
        public static List<Days> getDay()
        {
            return myDays;
        }
    }
}
