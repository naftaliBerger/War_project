public class Plane:Weapon
{
    public Plane(string Location, int Weapon_quantity) : base(Location, Weapon_quantity)
    {
        this.Territory = "Air";
    }
}