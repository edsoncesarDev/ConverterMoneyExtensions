namespace ConverterMoneyExtensions;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if (amount < 0)
            return 0;

        var number = amount
            .ToString("N2")
            .Replace(",", "")
            .Replace(".", "");

        if (string.IsNullOrEmpty(number))
            return 0;

        int.TryParse(number, out var result);
        return result;
    }
}
