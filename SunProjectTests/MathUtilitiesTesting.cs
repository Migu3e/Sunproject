using NUnit.Framework;
using SunProject.Code.MathUtilities;

public class Tests
{
    [Test]
    public void CalcMathUtilites()
    {
        int degrees = 90;
        Assert.That(((Math.PI / 180) * degrees), Is.EqualTo(SunProject.Code.MathUtilities.MathUtilities.ConvertDegreesToRadians(degrees)));
    }
}