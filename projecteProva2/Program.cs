

public class Program
{
    const string MsgAskDay = "Dia";
    const string MsgAskMonth = "Mes";
    const string MsgAskYear = "Any";

    public static void Main(string[] args)
    {
        CheckDateFormat();
    }

    public static void AskDate(out int day, out int month, out int year)
    {
        Console.WriteLine(MsgAskDay);
        day = UserNumImput();
        Console.WriteLine(MsgAskMonth);
        month = UserNumImput();
        Console.WriteLine(MsgAskYear);
        year = UserNumImput();
    }

    public static int UserNumImput()
    {
        int userNum = 0;
        bool validNum = false;
        do
        {
            Console.WriteLine(!validNum ? "Incorrecte, torna a probar:" : "Introdueix un numero:");
            validNum = int.TryParse(Console.ReadLine(), out userNum);
        } while (!validNum);
        return userNum;
    }

    public static void CheckDateFormat()
    {
        int day;
        int month;
        int year;
        int totalDaysMonth = 0;

        AskDate(out day, out month, out year);
        
        CheckMonthFormat(month, out totalDaysMonth); // dentro rango 1-12
        CheckYearFormat(year, out totalDaysMonth);
        CheckDayFormat(day, totalDaysMonth); // dentro rango 1-31
    }

    public static bool CheckDayFormat(int day, int totalDaysMonth)
    {
        return day >= 1 || day <= 31;
    }

    public static bool CheckMonthFormat(int month, out int totalDaysMonth)
    {
        if (month < 1 || month > 12)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                totalDaysMonth = 31;
                return true;
            }
            else
            {
                totalDaysMonth = 30;
                return true;
            }
        }
        else
        {
            totalDaysMonth = 0;
            return false;
        }
    }

    public static bool CheckYearFormat(int year, out int totalDaysMonth)
    {
        if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
        {
            totalDaysMonth = 29;
            return true;
        }
        else
        {
            totalDaysMonth = 28;
            return true;
        }
    }
}