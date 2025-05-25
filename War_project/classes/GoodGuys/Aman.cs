using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using War_project.classes;


namespace War_project.classes
{
    public class Aman
    {
       public List<Report> reports;
        public Aman()
        {
            reports = ManageDB_FACTOR.getReportFromDB();
        }

        public Report CreatReporByTerorist(Terrorist t)
        {
            Random random = new Random();
            string loc = random.Next(1000,2000).ToString() + ":"+random.Next(1000, 2000).ToString();

            string[] Areas = { "urban", "sea", "Air" };

           string Area = Areas[random.Next(0, 2)];
            Report rep = new Report(t, loc, "25052025", Area);
            return rep;
        }
    }
}
