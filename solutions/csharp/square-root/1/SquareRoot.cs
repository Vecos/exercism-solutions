public static class SquareRoot
{
    public static int Root(int number)
    {
        int left = 1, right = number;
        int result = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int squared = mid * mid;

            if (squared == number)
            {
                return mid;
            }
            else if (squared < number)
            {
                left = mid + 1;
                result = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}