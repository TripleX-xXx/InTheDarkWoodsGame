using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Endings
{
    Ending1,
    Ending2,
    Ending3,
    Ending4
}

public class DataStorage {

    public static void Check()
    {
        if(!PlayerPrefs.HasKey("Ending1"))
        {
            PlayerPrefs.SetInt("Ending1", 0);
        }
        if (!PlayerPrefs.HasKey("Ending2"))
        {
            PlayerPrefs.SetInt("Ending2", 0);
        }
        if (!PlayerPrefs.HasKey("Ending3"))
        {
            PlayerPrefs.SetInt("Ending3", 0);
        }
        if (!PlayerPrefs.HasKey("Ending4"))
        {
            PlayerPrefs.SetInt("Ending4", 0);
        }
        PlayerPrefs.Save();
    }

    public static void Save(Endings ending, bool isOpen)
    {
        if (isOpen)
        {
            PlayerPrefs.SetInt(EnumToString(ending), 1);
        }
        else
        {
            PlayerPrefs.SetInt(EnumToString(ending), 0);
        }
        PlayerPrefs.Save();
    }

    public static void Delete()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Check();
    }

    public static bool Load(Endings ending)
    {
        if (!PlayerPrefs.HasKey(EnumToString(ending)))
        {
            return false;
        }
        if (PlayerPrefs.GetInt(EnumToString(ending)) == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private static string EnumToString(Endings ending)
    {
        if (ending == Endings.Ending1) return "Ending1";
        else if (ending == Endings.Ending2) return "Ending2";
        else if (ending == Endings.Ending3) return "Ending3";
        else  return "Ending4";
    }

}
