public class Tank : Weapon
{
    public Tank(string Location, int Weapon_quantity) : base(Location, Weapon_quantity)
    {
        this.Territory = "land";
    }     
}