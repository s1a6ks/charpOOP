class Program
{
    static void Main(string[] args)
    {
        // Завдання 1

        string driveLetter = "D:";
        string groupName = "GroupKNms1b23"; 
        string LastName = "Goretsky"; 

        string rootDirectory = Path.Combine(driveLetter, "OOP_lab08");
        string groupDirectory = Path.Combine(rootDirectory, groupName);
        string lastNameDirectory = Path.Combine(rootDirectory, LastName);
        string sourcesDirectory = Path.Combine(rootDirectory, "Sources");
        string reportsDirectory = Path.Combine(rootDirectory, "Reports");
        string textsDirectory = Path.Combine(rootDirectory, "Texts");

        try
        {
            // 1) Створено каталог OOP_lab08 на диску D:
            Directory.CreateDirectory(rootDirectory);

            // 2) Створено необхідні каталоги
            Directory.CreateDirectory(groupDirectory);
            Directory.CreateDirectory(lastNameDirectory);
            Directory.CreateDirectory(sourcesDirectory);
            Directory.CreateDirectory(reportsDirectory);
            Directory.CreateDirectory(textsDirectory);

            // 3) Скопійовано каталоги Texts, Sources та Reports до каталогу 
            DirectoryCopy(textsDirectory, Path.Combine(lastNameDirectory, "Texts"));
            DirectoryCopy(sourcesDirectory, Path.Combine(lastNameDirectory, "Sources"));
            DirectoryCopy(reportsDirectory, Path.Combine(lastNameDirectory, "Reports"));

            // 4) Переміщується каталог Goretsky до каталогу groutKNms1b23
            Directory.Move(lastNameDirectory, Path.Combine(groupDirectory, LastName));

            // 5) У каталозі Texts створено текстовий файл dirinfo.txt з інформацією про каталог
            string dirInfoFilePath = Path.Combine(textsDirectory, "dirinfo.txt");
            using (StreamWriter writer = File.CreateText(dirInfoFilePath))
            {
                writer.WriteLine("Directory Information:");
                writer.WriteLine($"Directory Name: {textsDirectory}");
                writer.WriteLine($"Created On: {Directory.GetCreationTime(textsDirectory)}");
                writer.WriteLine($"Last Modified On: {Directory.GetLastWriteTime(textsDirectory)}");
            }

            Console.WriteLine("Операції завершено успішно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Виникла помилка: " + ex.Message);
        }

        // Завдання 2

        double epsilon = 0.001;

        string filePath = "sequence.txt"; // Шлях до файлу, куди записувати члени послідовності

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            int i = 1;
            double xi = 0;

            while (true)
            {
                double denominator = Math.Pow(i, 3) + Math.Abs(Math.Tan(2 * i));
                xi = (i - 0.1) / denominator;

                writer.WriteLine($"x{i} = {xi}");

                if (Math.Abs(xi) < epsilon)
                {
                    Console.WriteLine($"Перший член, для якого |xi| < ε: x{i} = {xi}");
                    break;
                }

                i++;
            }
        }

        // Функція для копіювання каталогу та його вмісту
        static void DirectoryCopy(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir);

            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                File.Copy(file, destFile);
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
                DirectoryCopy(subDir, destSubDir);
            }
        }
    }
}