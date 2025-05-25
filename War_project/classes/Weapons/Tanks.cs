using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_project.classes
{
    internal class Tanks:Brigade
    {
        public Tanks(List<Weapon> weapon = null) : base(weapon) 
        {
            this.AreaType = "urban";
        }
    }
}
