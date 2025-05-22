public class Tank : Weapon
{
    public Tank(string Location, int Weapon_quantity, string name) : base(Location, Weapon_quantity, name)
    {
        this.Territory = "land";
    }     
}