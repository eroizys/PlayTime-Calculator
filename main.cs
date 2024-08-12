using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("How many times have you travelled this year? ");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.Write("How long was your holiday this year? ");
        int holidayLength = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is it a leap year?(Yes/No) ");
        string ans = Console.ReadLine();

        Console.WriteLine(" ");
        Console.WriteLine("Total PlayTime: " + Convert.ToString(TotalPlay(h, holidayLength, ans)));


    }

    public static double NotWorking(int num)
    {
        return InDurban(num) * (3.0 / 4.0);
    }

    public static double InDurban(int num)
    {
        return 48 - num;
    }

    public static double PlayOnHoliday(int num)
    {
        return num * (2.0 / 3.0);
    }

    public static int HolidayWeekends(int num)
    {

        int fullWeeks = num / 7;
        int remainingDays = num % 7;

        int weekendDays = 0;

        if (remainingDays >= 5)
        {
            weekendDays++;

            if (remainingDays >= 6)
            {
                weekendDays++;
            }
        }

        int totalWeekends = fullWeeks + weekendDays;

        return totalWeekends;
    }

    public static double TotalPlay(int num1, int num2, string ans)
    {
        double result = ((NotWorking(num1) + num1) - HolidayWeekends(num2)) + PlayOnHoliday(num2);

        if (ans == "Yes")
        {
            result = result * 1.2;
        }

        return Math.Floor(result);
    }
}