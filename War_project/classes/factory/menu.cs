using System;
using War_project.classes;

public static class Menu
{
    public static void menu(IDF idf)
    {
        bool exit = true;
        while (exit)
        {
            Console.WriteLine("-------Welcome to the IDF------");
            Console.WriteLine("*****menu*****");
            Console.WriteLine("Enter 1 for a list of dead terrorists.\n" +
                "Enter 2 for a list of living terrorists.\n" +
                "Enter 3 for a current supply list.\n" +
                "Enter 4 to add a terrorist.\n" +
                "Enter 5 to add a report on a terrorist.\n" +
                "Enter 6 to attack a specific terrorist (by name).\n" +
                "Enter 7 for a random attack.\n");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    {
                        exit = false;
                        break;
                    }
                case 1:
                    {
                        idf.ManagWar.ShowDadTerorist();
                        break;
                    }
                case 2:
                    {
                        idf.ManagWar.ShowAliveTerorist();
                        break ;
                    }
                case 3:
                    {
                        idf.ManagWar.ShowReapons();
                        break;
                    }
                case 4:
                    {
                        idf.ManagWar.AddTerorrist();
                        break;
                    }
                case 5:
                    {
                        
                        idf.ManagWar.addReaport();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("enter name");
                        string name = Console.ReadLine();
                        idf.ManagWar.attactByName(name);
                        break;
                    }
                case 7:
                    {
                        idf.ManagWar.randomAttac();
                         break;
                    }

            }
        }
    }
}