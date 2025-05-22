public class Ship : Weapon
{
    public Ship(string Location, int Weapon_quantity , string name) : base(Location, Weapon_quantity ,name)
    {
        this.Territory = "sea";
    }
}