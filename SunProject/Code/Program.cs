using SunProject;
using SunProject.Code.MathUtilities;
using SunProject.Code.Date;
using SunProject.Code.Analemma;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int year = 2024;
        double latitude = 32.19306;
        double longitude = 34.7818;

        Analemma analemma = new Analemma(latitude);
        Date date = new Date
        {
            Day = 15,
            Month = 5,
            Year = year,
        };

        // Utilize DateUtilities for Julian date calculation
        DateUtilities dateUtilities = new DateUtilities();

        // PrintService to handle printing tasks
        PrintService printService = new PrintService();

        if (date.CheckDate())
        {
            int J = dateUtilities.CalculateJulianDate(new Date { Day = 1, Month = 1, Year = year }, date);

            double yAxis = analemma.CalculateYAxis(J);
            double xAxis = analemma.CalculateXAxis(J);
            double altitude = analemma.CalculateAltitude(yAxis);
            double xAxisCorrection = analemma.CorrectXAxis(xAxis);

            Console.WriteLine("x: " + xAxisCorrection);
            Console.WriteLine("y: " + yAxis);
            printService.PrintAllInDate(date, yAxis, xAxisCorrection, altitude);
        }

        // Print all details for the year 2024 using the PrintService
        if (date.CheckDate())
        {
            printService.PrintAllYearDetails(year, latitude); // Assuming we add latitude handling to PrintAllYearDetails
        }
    }
}
