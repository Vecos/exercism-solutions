public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
    int pom = 0;
    for (int i = 0; i<=max; i++)
    {
    pom += i;
   // pom = pom + i;
    }
      return pom * pom; 
    }

    public static int CalculateSumOfSquares(int max)
    {
    int pom = 0;
    int pom1  = 0;
    for (int i = 0;i<=max;i++)
    {
        // pom *= i;
        pom = i * i; 
    
        pom1 += pom;
    }
        return pom1;
    }

    public static int CalculateDifferenceOfSquares(int kokot) => CalculateSquareOfSum(kokot) - CalculateSumOfSquares(kokot);
}




