using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hostels;

public static class Campus
{
 

    public static List<Hostel> hostels = new List<Hostel>(0);
    public static List<int> DeleteHostels = new List<int>(0);

    public static int GetID()
    {
        if (DeleteHostels.Count != 0)
        {
            int temp = DeleteHostels[0];
            DeleteHostels.RemoveAt(0);
            return temp;
        }
        else if (hostels.Count == 0)
        {
            return 1;
        }
        else
        {
            int max = 0, value = 0;
            for (int i = 0; i < hostels.Count; i++)
            {
                value = hostels[i].ID;
                if (value > max) max = value;
            }
            return max + 1;
        }
    }

    public static bool switchImageString(string str)
    {
        if (str != "")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool switchImageInt(string str, out int num)
    {
        if (str != "" && int.TryParse(str, out num) && num >= 0)
        {
            return true;
        }
        else
        {
            num = -1;
            return false;
        }
    }

    public static bool FindingHostel(int id, out Hostel? hostel)
    {
        hostel = hostels.Find(h => h.ID == id);
        if (hostel == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
