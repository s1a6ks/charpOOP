class DateAnalysis
{
    // Метод для знаходження року з найменшим номером
    public static int FindYearWithMinimumNumber(string input)
    {
        // Розділити вхідний рядок на окремі дати
        string[] dateStrings = input.Split(',');
        
        // Ініціалізувати змінну для мінімального року
        int minYear = int.MaxValue;

        // Пройтися по кожній даті і визначити рік з мінімальним номером
        foreach (var dateString in dateStrings)
        {
            // Розділити рядок на частини за пробілами
            string[] parts = dateString.Trim().Split(' ');

            // Перевірити, чи дата містить рік у правильному форматі
            if (parts.Length == 3)
            {
                int year;
                // Спробувати перетворити рік в число
                if (int.TryParse(parts[2], out year) && year < minYear)
                {
                    minYear = year;
                }
            }
        }

        // Повернути знайдений мінімальний рік
        return minYear;
    }

    // Метод для пошуку весняних дат
    public static string[] FindSpringDates(string input)
    {
        // Розділити вхідний рядок на окремі дати
        string[] dateStrings = input.Split(',');
        
        // Вибрати дати, які містять "весна" або "spring"
        string[] springDates = dateStrings
            .Where(s => s.Contains("весна") || s.Contains("spring"))
            .ToArray();
        return springDates;
    }

    // Метод для знаходження самої пізньої дати
    public static string FindLatestDate(string input)
    {
        // Розділити вхідний рядок на окремі дати
        string[] dateStrings = input.Split(',');

        // Ініціалізувати змінну для збереження самої пізньої дати
        DateTime latestDate = DateTime.MinValue;

        // Пройтися по кожній даті і знайти найпізнішу дату
        foreach (var dateString in dateStrings)
        {
            DateTime date;
            // Спробувати перетворити рядок в об'єкт DateTime
            if (DateTime.TryParse(dateString.Trim(), out date) && date > latestDate)
            {
                latestDate = date;
            }
        }

        // Повернути знайдену найпізнішу дату у форматі "dd.MM.yyyy"
        return latestDate.ToString("dd.MM.yyyy");
    }
}
