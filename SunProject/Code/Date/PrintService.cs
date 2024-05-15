namespace SunProject.Code.Date;

public class PrintService
{
    public void PrintAllInDate(Date date, double yAxis, double xAxisCorrection, double altitude)
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Date is: {date.Day}/{date.Month}/{date.Year}\nAltitude is: {altitude}");
        PrintTimeOfSunNoon(date, xAxisCorrection);
        Console.WriteLine("-------------------------------------------------");
    }

    public void PrintTimeOfSunNoon(Date date, double xAxisCorrection)
    {
        bool isSummer = new DaylightSaving().IsSummerTime(date);
        int hour = isSummer ? 12 : 11;
        int minutes = (int)(60 - 19.74 - xAxisCorrection);
        Console.WriteLine($"Time of SunNoon: {hour}:{minutes}");
    }
}