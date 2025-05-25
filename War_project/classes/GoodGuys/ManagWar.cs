using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using War_project.classes;

public class ManagWar
{
    public FirePower firePower { get; set; }

    public Aman aman { get; set; }

    public TerorOrg org { get; set; }

    public void setArmmy(FirePower firePower, Aman aman)
    {
        this.firePower = firePower;
        this.aman = aman;
    }

    public void setTerorOrg(TerorOrg org) 
    { 
        this.org = org;
    
    }

    public void CreatReporsByNum(int num)
    {
        List<Terrorist> listT = org.GetTeroristsByNun(num);
    }

    public void randomAttac()
    {
        Random rnd = new Random();

        Report report = aman.reports[rnd.Next(0,aman.reports.Count)];

        if (firePower.isAbleAttack(report))
        {
            Weapon w = firePower.getWeaponToAttack(report);
            w.attack(report);

        }

        else
        {
            Console.WriteLine("not cen attack try egen ");
            this.randomAttac();
        }
        
    }

    public void ShowAliveTerorist()
    {
        List<Terrorist> teror = org.terrorists.Where(x => x.situation == true).ToList();
       
        foreach(Terrorist t in teror)
        {
            Console.WriteLine($"name : {t.name} rank:{t.rank} weapon :{t.weapon}");
        }
    }

    public void ShowDadTerorist()
    {
        List<Terrorist> teror = org.terrorists.FindAll(x => x.situation == false).ToList();
       
        foreach (Terrorist t in teror)
        {
            Console.WriteLine($"name : {t.name} rank:{t.rank} weapon :{t.weapon}");
        }
    }


    public void ShowReapons()
    {
        Console.WriteLine($"count of tanks {firePower.Brigades[0].weapon.Count}");
        foreach (Weapon t in firePower.Brigades[0].weapon)
        {
            Console.WriteLine($" team name : {t.name} count of booms {t.Weapon_quantity}");
        
        }
        Console.WriteLine($"count of ships {firePower.Brigades[1].weapon.Count}");
        foreach (Weapon t in firePower.Brigades[1].weapon)
        {
            Console.WriteLine($" team name : {t.name} count of booms {t.Weapon_quantity}");

        }
        Console.WriteLine($"count of planse {firePower.Brigades[2].weapon.Count}");
        foreach (Weapon t in firePower.Brigades[2].weapon)
        {
            Console.WriteLine($" team name : {t.name} count of booms {t.Weapon_quantity}");

        }


       
    }

    public void AddTerorrist()
    {
        Console.WriteLine(" enter: name , rank, weapon");
        string[] input = Console.ReadLine().Split();
        Terrorist t = new Terrorist(input[0], int.Parse(input[1]), true, input[2]);
        org.addterrorist(t);
        Console.WriteLine($"added {input[0]}");
    }

    public void addReaport()
    {
        Console.WriteLine("enter name or ''");
        string name = Console.ReadLine();
        Random rand = new Random();
        Terrorist t;
        if (name == "")
        {
             t = org.terrorists[rand.Next(0,org.terrorists.Count -1)];
        }
        else { t = org.terrorists.Find(x => x.name == name); }

        if (t == null) { Console.WriteLine("no terorist in dis name"); }
        else { 
              Report r = aman.CreatReporByTerorist(t);
             aman.reports.Add(r);

        }
             
        
    }

    public void attactByName(string name) 
    {
        Report t = aman.reports.Find(x => x.terrorist.name == name);

        if (t == null)
        {
            Console.WriteLine("no terorist");
            return;
        }
        if (firePower.isAbleAttack(t) )
        {
           Weapon w = firePower.getWeaponToAttack(t);
            w.attack(t);
        }
        else { Console.WriteLine("no weapon to attack"); }

    }





}