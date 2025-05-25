using System;
using System.Collections.Generic;
using System.IO;
using War_project.classes;
using War_project.classes.NewFolder1;

public class FirePower
{
    public List<Brigade> Brigades;

    public FirePower()
    {
        Brigades = ManageDB_FACTOR.GetWeaponsFromDB();

    }


    public bool isAbleAttack(Report report)
    {
        Brigade BrigadAble = Brigades.Find(x => x.CheckTypeArea(report.Area));

        if (BrigadAble == null) { return false; }

        if (BrigadAble.IsSomAvailable(report))
        {
            return true;
        }
        

        return false;
    }

    public Weapon getWeaponToAttack(Report report)
    {

        Brigade BrigadAble = Brigades.Find(x => x.CheckTypeArea(report.Area));
        return BrigadAble.GetWeaponToAttact(report);

    }
}