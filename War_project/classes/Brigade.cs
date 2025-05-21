using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Iweapon
{
    // Define the members of the Iweapon interface here  
}
public interface Ireport
{
    // Define the members of the Iweapon interface here  
}


public class Brigade
{
    public List<Iweapon> weapon { get; set; } = new List<Iweapon>();

    public string AreaType;
    public Brigade(List<Iweapon> weapon = null)
    {
        if (weapon == null) weapon = new List<Iweapon>();
        else { this.weapon = weapon; }
        
    }

    public void Addweapon(Iweapon weapon)
    {
        this.weapon.Add(weapon);
    }

    public Iweapon GetIweaponToAttact(Ireport report)
    { 
        return null;
    
    
    }

}
