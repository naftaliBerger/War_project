using System;

public static class Menu
{
    public static void menu()
    {
        bool exit = true;
        while (exit)
        {
            Console.WriteLine("-------Welcome to the IDF------");
            Console.WriteLine("*****menu*****");
            Console.WriteLine("Enter 1 for a list of dead terrorists." +
                "Enter 2 for a list of living terrorists." +
                "Enter 3 for a current supply list." +
                "Enter 4 to add a terrorist." +
                "Enter 5 to add a report on a terrorist." +
                "Enter 6 to attack a specific terrorist (by name)." +
                "Enter 7 for a random attack.");
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
                        break;
                    }
                case 2:
                    {
                        break ;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                case 7:
                    {
                         break;
                    }

            }
        }
    }
}