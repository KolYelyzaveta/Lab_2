using Lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Hostels;
public class Hostel : ICloneable
{
    private int roomsNumber;
    private int studentAmount;
    private int stuffNumber;

    public int ID { get; set; }
    public string universityName { get; set; }
    public string hostelAddress { get; set; }
    public int StuffNumber
    {
        get => stuffNumber;
        set
        {
            if (value >= 1 && value < 1000) stuffNumber = value;
            else throw new Exception("Incorrect number of employees");
        }
    }
    public int RoomsNumber
    {
        get { return roomsNumber; }
        set
        {
            if (value >= 0 && value < 1000) roomsNumber = value;
            else throw new Exception("Incorrect number of rooms");
        }
    }
    public int StudentAmount
    {
        get => studentAmount;
        set
        {
            if (value <= (RoomsNumber * 3)) studentAmount = value;
            else throw new Exception("The number of students exceeds the number of places in the hostel");
        }
    }
    public double hostelProfit { get; set; }

    public Hostel(int id, string universityName, string hostelAddress, int StuffNumber, int RoomsNumber)
    {
        ID = id;
        this.universityName = universityName;
        this.hostelAddress = hostelAddress;
        this.StuffNumber = StuffNumber;
        this.RoomsNumber = RoomsNumber;
        CalcProfit();
    }

    public void CalcProfit()
    {
        double profit = 0.0;
        profit += StudentAmount * 800;
        profit -= StuffNumber * 5000;
        hostelProfit = profit;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Назва університету:\t{universityName}\n");
        sb.Append($"Адреса гуртожитку:\t{hostelAddress}\n");
        sb.Append($"Кількість працівників:\t{StuffNumber}\n");
        sb.Append($"Кількість кімнат:\t\t{RoomsNumber}\n");
        sb.Append($"Кількість студентів:\t{StudentAmount}\n");
        sb.Append($"Прибуток:\t\t{hostelProfit}\n");
        return sb.ToString();
    }

    public object Clone()
    {
        return new Hostel (ID, universityName, hostelAddress, StuffNumber, RoomsNumber);
    }
}
