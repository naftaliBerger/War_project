using System;
using System.Collections.Generic;
using System.Dynamic;
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










}