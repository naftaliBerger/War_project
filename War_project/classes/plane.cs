public class Plane:Weapon
{
    public Plane(string Location, int Weapon_quantity, string name) : base(Location, Weapon_quantity, name)
    {
        this.Territory = "Air";
    }
}