namespace SunProject.Code.Analemma;

public interface IAnalemmaCalculations
{
    double CalculateYAxis(int julianDay);
    double CalculateXAxis(int julianDay);
    double CalculateAltitude(double yAxisValue);
    double CorrectXAxis(double xAxisValue);
}
