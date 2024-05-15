namespace SunProject.Code.Date;

public class DaylightSaving
{
    public bool IsSummerTime(Date date)
    {
        return date.Month > 3 && date.Month < 10 || (date.Month == 3 && date.Day >= 24) || (date.Month == 10 && date.Day <= 29);
    }
}