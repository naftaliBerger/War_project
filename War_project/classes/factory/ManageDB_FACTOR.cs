using System.Collections.Generic;
using War_project.classes.NewFolder1;
using War_project.classes;
using System.IO;
public static class ManageDB_FACTOR
{
    public static  List<Brigade> GetWeaponsFromDB()
    {
        List<Weapon> tanks = new List<Weapon>();
        List<Weapon> ships = new List<Weapon>();
        List<Weapon> airplanes = new List<Weapon>();

        var f = File.ReadAllLines(@"..\..\db\weapon.txt");




        foreach (var line in f)
        {
            string[] strings = line.Split();
            switch (strings[0])
            {
                case "tank":

                    tanks.Add(new Tank(strings[1], int.Parse(strings[2]), strings[3]));
                    break;
                case "ship":
                    tanks.Add(new Ship(strings[1], int.Parse(strings[2]), strings[3]));
                    break;
                case "plane":
                    tanks.Add(new Plane(strings[1], int.Parse(strings[2]), strings[3]));
                    break;



            }


        }


        Brigade tanks1 = new Tanks(tanks);
        Brigade airplanes1 = new Airplanes(airplanes);
        Brigade ships1 = new Ships(ships);

        return new List<Brigade>() { tanks1, airplanes1, ships1 };

    }


    public static List<Report> getReportFromDB()
    {
        List<Report> reports = new List<Report>();

        var f = File.ReadAllLines(@"..\..\db\Reports.txt");




        foreach (var line in f)
        {
            string[] strings = line.Split();
            Report r = new Report(new Terrorist(strings[0], int.Parse(strings[1]), bool.Parse(strings[2]), strings[3]), strings[4], strings[5], strings[6]);
            reports.Add(r);
        }

        return reports;
    }

    public static List<Terrorist> getTerroriststFromDB()
    {
        List<Terrorist> Terrorists = new List<Terrorist>();

        var f = File.ReadAllLines(@"..\..\db\Terrorists.txt");




        foreach (var line in f)
        {
            string[] strings = line.Split();
            Terrorist t = new Terrorist(strings[0], int.Parse(strings[1]), bool.Parse(strings[2]), strings[3]);
            Terrorists.Add(t);
        }

        return Terrorists;
    }
}