using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class Brigade
{
    public List<Weapon> weapon { get; set; } = new List<Weapon>();

    public string AreaType;
    public Brigade(List<Weapon> weapon = null)
    {
        if (weapon == null) weapon = new List<Weapon>();
        else { this.weapon = weapon; }
        
    }

    public void Addweapon(Weapon weapon)
    {
        this.weapon.Add(weapon);
    }
    
    public bool IsSomAvailable(Report report)
    {
        bool resolt = weapon.Any(x => x.adjustment(report));
        return resolt;
    }
    public Weapon GetWeaponToAttact(Report report)
    {
        Weapon chich = weapon.Find(x => x.adjustment(report));
        return chich;
    
    
    }

    public bool CheckTypeArea(string Area)
    {
        return Area == this.AreaType;
    }

}
