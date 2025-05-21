public class Ship : Weapon
{
    public Ship(string Location, int Weapon_quantity) : base(Location, Weapon_quantity)
    {
        this.Territory = "sea";
    }
}