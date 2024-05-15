namespace SunProject.Code.Date;

public class DateUtilities
{
    public int CalculateJulianDate(Date startDate, Date endDate)
    {
        int count = 0;
        Date tempDate = new Date { Day = startDate.Day, Month = startDate.Month, Year = startDate.Year };
        while (tempDate.Day != endDate.Day || tempDate.Month != endDate.Month || tempDate.Year != endDate.Year)
        {
            tempDate = tempDate.GiveNextDay();
            count++;
        }
        return count;
    }
}