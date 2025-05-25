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










}