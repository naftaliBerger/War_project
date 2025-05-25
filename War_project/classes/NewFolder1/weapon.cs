using System;
using System.Linq;

public class Weapon
{
    public string Territory;//שטח
    public string Location;//נ.צ
    public int Weapon_quantity;//כמות נשק
    public string name;


    public Weapon( string Location, int Weapon_quantity , string name)
    {
        this.name = name;
        this.Location = Location;
        this.Weapon_quantity = Weapon_quantity;
    }
    public bool adjustment(Report report)
    {
        if(this.Weapon_quantity >0)
        {
            int[] my_loc = Location.Split(':').Select(x => int.Parse(x)).ToArray();
            int[] enmy_loc = report.Location.Split(':').Select(x => int.Parse(x)).ToArray();
            if (my_loc[0] - enmy_loc[0] > -50 && my_loc[0] - enmy_loc[0] < 50)
                return true;
            if (my_loc[1] - enmy_loc[1] > -50 && my_loc[1] - enmy_loc[1] < 50)
                return true;
        }
      

        return false ;
    }

    public void attack(Report report)
    {
        ///להעביר את המחבל שבדוח למוות
        report.terrorist.situation=false;

        this.Weapon_quantity -= 1;

        Console.WriteLine($"terrorist: {report.terrorist.name} attack by {name}  ");
    }

}
