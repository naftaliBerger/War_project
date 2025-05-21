using System.Collections.Generic;
interface Iweapon { }
public class FirePower
{
   private List<Iweapon> _weapons { get; set; } 

    public FirePower() 
    {
        _weapons = GetFromDB();

    }

    private List<Iweapon> GetFromDB()
    {
        return new List<Iweapon>();
    }
}