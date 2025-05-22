using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_project.classes
{
    internal class IDF
    {
        public string ramatcal;
        public string date;
        public FirePower firePower { get; set; }
        public Aman aman { get; set; }
        public IDF(string ramatcal , string date)
        {
            firePower = new FirePower();
            aman = new Aman();
            this.ramatcal = ramatcal;
            this.date = date;
        }



        
    }
}
