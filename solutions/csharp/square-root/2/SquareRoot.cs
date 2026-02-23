public static class SquareRoot
{
    public static int Root(int number)
    {
    int num = 1;
    while (num * num != number)
    {
        num++;
    }

        return num;
    }
}