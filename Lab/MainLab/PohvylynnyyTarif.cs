// Клас, що представляє тариф на послуги, де вартість розмови обчислюється за хвилинами.
using MainLab;

public class PohvylynnyyTarif
{
    public double VartistHvylynyRozmovy { get; set; }

    // Метод для розрахунку вартості розмови на основі кількості секунд.
    public double RozrahuvatyVartistRozmovy(int kilkistSekund)
    {
        try
        {
            if (kilkistSekund < 0)
            {
                throw new KilkistSekundException();
            }
            return Math.Ceiling((double)kilkistSekund / 60) * VartistHvylynyRozmovy;
        }
        catch (KilkistSekundException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return 0;
        }
    }
}