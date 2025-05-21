using System.Collections.Generic;
using System.IO;
using War_project.classes;

public class FirePower
{
    private List<Brigade> Brigades;

    public FirePower()
    {
        Brigades = GetFromDB();

    }

    private List<Brigade> GetFromDB()
    {
        List<Weapon> tanks = new List<Weapon>();
        List<Weapon> ships = new List<Weapon>();
        List<Weapon> airplanes = new List<Weapon>();

        var f = File.ReadAllLines("weapon.txt");


        foreach (var line in f)
        {
            string[] strings = line.Split();
            switch (strings[0])
            {
                case "tank":
                   // tanks.Add(new Tank());
                    break;
                case "ship":
                   // tanks.Add(new Ship());
                    break;
                case "airplane":
                    //tanks.Add(new Airplane());
                    break;


            }


        }


        Brigade tanks1 = new Tanks(tanks);
        Brigade airplanes1 = new Airplanes(airplanes);
        Brigade ships1 = new Ships(ships);

        return new List<Brigade> (){  tanks1 , airplanes1,ships1 };

    }

}