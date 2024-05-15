namespace SunProject.Code.Analemma;
using SunProject.Code.MathUtilities;
public class Analemma : AnalemmaBase, IAnalemmaCalculations
{
    public Analemma(double latitude) : base(latitude)
    {
    }
    public double CalculateYAxis(int julianDay)
    {
        return 23.4 * Math.Sin(MathUtilities.ConvertDegreesToRadians((360.0 / 365.0) * (julianDay - 79)));
    }
    public double CalculateXAxis(int julianDay)
    {
        return (7.66 / 4.0) * Math.Sin(MathUtilities.ConvertDegreesToRadians(360.0 / 365.0 * (julianDay - 186)))
               + (9.87 / 4.0) * Math.Sin(MathUtilities.ConvertDegreesToRadians(720.0 / 365.0 * (julianDay - 79)));
    }
    public double CalculateAltitude(double yAxisValue)
    {
        double altitude = Latitude - yAxisValue;
        return 90 - altitude;
    }
    public double CorrectXAxis(double xAxisValue)
    {
        return xAxisValue * 4.3;
    }
}