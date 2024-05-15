namespace SunProject.Code.Date;

public class Date
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public bool CheckDate()
    {
        return Month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => Day <= 31,
            4 or 6 or 9 or 11 => Day <= 30,
            2 => (Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0)) ? Day <= 29 : Day <= 28,
            _ => false,
        };
    }

    public Date GiveNextDay()
    {
        Date result = new Date { Day = Day, Month = Month, Year = Year };
        bool isLeapYear = Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0);
        int daysInMonth = Month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => isLeapYear ? 29 : 28,
            _ => throw new InvalidOperationException("Invalid month")
        };

        result.Day++;
        if (result.Day > daysInMonth)
        {
            result.Day = 1;
            result.Month++;
            if (result.Month > 12)
            {
                result.Month = 1;
                result.Year++;
            }
        }

        return result;
    }
}