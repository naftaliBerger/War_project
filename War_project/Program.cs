﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War_project.classes;

namespace War_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDF idf = IDF.GetIDF("hilh", "hiuhi");
            idf.StartWar();
            idf.ManagWar.setTerorOrg(new Hamas(ManageDB_FACTOR.getTerroriststFromDB()));

            Menu.menu(idf);

        }
    }
}
