class DateAnalysis
{
    // Метод для знаходження року з найменшим номером
    public static int FindYearWithMinimumNumber(string input)
    {
        string[] dateStrings = input.Split(',');
        int[] years = dateStrings.Select(s => int.Parse(s.Split(' ')[2])).ToArray();
        return years.Min();
    }

    // Метод для пошуку весняних дат
    public static string[] FindSpringDates(string input)
    {
        string[] dateStrings = input.Split(',');
        string[] springDates = dateStrings.Where(s => s.Contains("весна")).ToArray();
        return springDates;
    }

    // Метод для знаходження самої пізньої дати
    public static string FindLatestDate(string input)
    {
        string[] dateStrings = input.Split(',');
        DateTime[] dates = dateStrings.Select(s => DateTime.Parse(s.Trim())).ToArray();
        DateTime latestDate = dates.Max();
        return latestDate.ToString("dd.MM.yyyy");
    }
}
