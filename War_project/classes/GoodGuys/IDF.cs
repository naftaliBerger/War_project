using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_project.classes
{
    public class IDF
    {
        private static IDF idf = null;

        public string ramatcal;
        public string date;
        public FirePower firePower { get; set; }
        public Aman aman { get; set; }

        public ManagWar ManagWar { get; set; }
        private IDF(string ramatcal , string date)
        {
            firePower = new FirePower();
            aman = new Aman();
            this.ramatcal = ramatcal;
            this.date = date;
        }

        public static IDF GetIDF(string ramatcal, string date)
        {
            if (idf == null)
            {
                idf = new IDF(ramatcal, date);
            }
            return idf;
        }

        public void StartWar() 
        {
            this.ManagWar = new ManagWar();
            ManagWar.setArmmy(this.firePower, this.aman);
        } 
    }
}
