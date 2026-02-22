public static class RomanNumeralExtensions
{
    public static string ToRoman(this int number)
    {
        if (number <= 0 || number > 3999)
            throw new ArgumentOutOfRangeException(nameof(number));

        var map = new (int value, string symbol)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var result = "";

        foreach (var (value, symbol) in map)
        {
            while (number >= value)
            {
                result += symbol;
                number -= value;
            }
        }

        return result;
    }
}