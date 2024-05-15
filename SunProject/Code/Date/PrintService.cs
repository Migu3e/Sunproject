namespace SunProject.Code.Date;
using SunProject.Code.Analemma;
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
    public void PrintAllYearDetails(int year, double latitude)
    {
        Date currentDate = new Date { Day = 1, Month = 1, Year = year };
        Analemma analemma = new Analemma(latitude);

        while (currentDate.Year == year)
        {
            int J = new DateUtilities().CalculateJulianDate(new Date { Day = 1, Month = 1, Year = year }, currentDate);
            double yAxis = analemma.CalculateYAxis(J);
            double xAxis = analemma.CalculateXAxis(J);
            double altitude = analemma.CalculateAltitude(yAxis);
            double xAxisCorrection = analemma.CorrectXAxis(xAxis);
        
            PrintAllInDate(currentDate, yAxis, xAxisCorrection, altitude);
            currentDate = currentDate.GiveNextDay();
        }
    }
}