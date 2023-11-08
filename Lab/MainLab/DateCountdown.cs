class DateCountdown
{
    // Метод, який підраховує кількість днів до вказаної дати
    public static int DaysUntilDate(DateTime targetDate)
    {
        DateTime currentDate = DateTime.Now;

        // Перевірка, чи вказана дата вже минула
        if (currentDate >= targetDate)
        {
            Console.WriteLine("Цей день вже минув.");
            return 0;
        }
        return (targetDate - currentDate).Days;
    }
}