// завдання 1

string input = "0101010101";
        int startPosition = 3;
        string result = StringManipulation.ReplaceOnesWithZerosAndZerosWithOnes(input, startPosition);
        Console.WriteLine(result);


// завдання 2

DateTime targetDate = new DateTime(2023, 12, 31);
        int daysUntil = DateCountdown.DaysUntilDate(targetDate);
        Console.WriteLine($"Днів до вказаної дати: {daysUntil}");



// завдання 3


string input2 = "10 січня 2023, 20 квітня 2023, 15 березня 2023";
        
        int minYear = DateAnalysis.FindYearWithMinimumNumber(input2);
        Console.WriteLine($"Рік з найменшим номером: {minYear}");

        string[] springDates = DateAnalysis.FindSpringDates(input2);
        Console.WriteLine($"Весняні дати: {string.Join(", ", springDates)}");

        string latestDate = DateAnalysis.FindLatestDate(input2);
        Console.WriteLine($"Сама пізня дата: {latestDate}");