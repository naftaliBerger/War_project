using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Weapon
{
    // Define the members of the Iweapon interface here  
}
public interface Ireport
{
    // Define the members of the Iweapon interface here  
}

public class Tank: Weapon
{
    string Territory { get; set; }
    string Location { get; set; }
    string Weapon_quantity { get; set; }
}

public class Brigade
{
    public List<Weapon> weapon { get; set; } = new List<Iweapon>();

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

    public Weapon GetIweaponToAttact(Ireport report)
    { 
        return null;
    
    
    }

}
