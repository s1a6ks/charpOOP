using MainLab;

internal class Program
{
    private static void Main(string[] args)
    {

        Tarif tarif;
        try
        {
            // Спроба створити тариф з порожньою назвою.
            tarif = new Tarif("");
        }
        catch (NazvaException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        PossekundniyTarif possekundniyTarif = new PossekundniyTarif { VartistSekundiRozmovy = 0.1 };
        PohvylynnyyTarif pohvylynnyyTarif = new PohvylynnyyTarif { VartistHvylynyRozmovy = 0.5 };

        int kilkistSekund = -100;

        // Розрахунок вартості розмови за двома різними тарифами з перевіркою винятків.
        double vartistRozmovyPossekundniy = possekundniyTarif.RozrahuvatyVartistRozmovy(kilkistSekund);
        double vartistRozmovyPohvylynnyy = pohvylynnyyTarif.RozrahuvatyVartistRozmovy(kilkistSekund);

        Console.WriteLine($"Вартість розмови за посекундним тарифом: {vartistRozmovyPossekundniy}");
        Console.WriteLine($"Вартість розмови за похвилинним тарифом: {vartistRozmovyPohvylynnyy}");



    }
}