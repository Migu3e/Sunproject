namespace SunProject.Code.MathUtilities
{
    public static class MathUtilities
    {
        // Converts an angle from degrees to radians.
        public static double ConvertDegreesToRadians(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }
    }
}

