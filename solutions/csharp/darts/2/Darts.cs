public static class Darts
{
 
      public static int Score(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y); 

        // if (distance <= 1.0) return 10;
        // if (distance <= 5.0) return 5;
        // if (distance <= 10.0) return 1;
        // return 0;
        return distance <= 1.0f  ? 10 : distance <= 5.0f ? 5: distance <= 10.0f ? 1: 0;
    }
}
