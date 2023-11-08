// Клас, що представляє тариф на послуги, де вартість розмови обчислюється за секундами.
using MainLab;

public class PossekundniyTarif
{
    public double VartistSekundiRozmovy { get; set; }

    // Метод для розрахунку вартості розмови на основі кількості секунд.
    public double RozrahuvatyVartistRozmovy(int kilkistSekund)
    {
        try
        {
            if (kilkistSekund < 0)
            {
                throw new KilkistSekundException();
            }
            return kilkistSekund * VartistSekundiRozmovy;
        }
        catch (KilkistSekundException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return 0;
        }
    }
}