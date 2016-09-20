using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buddy.Models
{
    public class Unit
    {
        public String code { get; set; }
        public String name { get; set; }
        public String lecturer { get; set; }
        public String lessonNumber { get; set; }
        public String lectureRoom { get; set; }
        public String day { get; set; }
        public String time { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}",code, Environment.NewLine, name, Environment.NewLine, lecturer, Environment.NewLine, day, Environment.NewLine, time);
        }
    }
}
