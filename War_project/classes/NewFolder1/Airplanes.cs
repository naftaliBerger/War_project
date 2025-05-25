using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_project.classes
{
    internal class Airplanes:Brigade
    {
        public Airplanes(List<Weapon> weapon = null) : base(weapon)
        {
            this.AreaType = "Air";
        }
    }
}
