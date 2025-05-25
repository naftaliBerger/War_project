using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_project.classes.NewFolder1
{
    public class Tank : Weapon
    {
        public Tank(string Location, int Weapon_quantity, string name) : base(Location, Weapon_quantity, name)
        {
            this.Territory = "urban";
        }
    }
}
