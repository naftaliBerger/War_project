using System;

public class Report
{
   public Terrorist terrorist;
   public string Location;
   public string time;
   public string Area;


    public Report(Terrorist terrorist, string location, string time, string area) 
    {
        this.terrorist = terrorist;
        Location = location;
        this.time = time;
        Area = area;
    }

    public void CreatReport(Terrorist terrorist)
    {
        Random random = new Random();
        this.terrorist = terrorist;
        Location = random.Next(1000, 2000).ToString() +":"+ random.Next(1000, 2000).ToString();
        time = "10052025";
        string[] Areas = { "urban", "sea", "Air" };

        Area = Areas[random.Next(0,2)];
    }  
}