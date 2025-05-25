using System;
using System.Collections.Generic;

public class TerorOrg
{
    public string name;
    public List<Terrorist> terrorists;

    public TerorOrg(List<Terrorist> terrorists)
    {
        this.terrorists = terrorists;
    }

    public void addterrorist(Terrorist terrorist)
    {
        this.terrorists.Add(terrorist);
    }

    public List<Terrorist> GetTeroristsByNun(int nun)
    { 
        List<Terrorist> terrorists = new List<Terrorist>();
        Random rand = new Random();
        for (int i = 0; i < nun; i++) 
        {
            terrorists.Add(this.terrorists[rand.Next(0,this.terrorists.Count -1)]);
        }

        return terrorists;
    }


}