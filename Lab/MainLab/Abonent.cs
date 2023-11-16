using System;


class KilkistSekundException : Exception
{
    public KilkistSekundException(string message) : base(message)
    {
    }
}

class NazvaException : Exception
{
    public NazvaException(string message) : base(message)
    {
    }
}

class Tarif
{
    private string nazva;

    public string Nazva
    {
        get { return nazva; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NazvaException("Неможливо створити тариф – не вказано назву");
            }
            nazva = value;
        }
    }

    public Tarif(string nazva)
    {
        Nazva = nazva;
    }
}

class Abonent
{
    public Abonent(string pib, string number, Double zalRah)
    {
    PIB = pib;
    NomerTelefonu = number;
    ZalishokNaRahunku = zalRah;
    }

    public string ?PIB { get; set; }
    public string ?NomerTelefonu { get; set; }
    public double ZalishokNaRahunku { get; set; }

    
}

class PosekundnyiTarif : Tarif
{
    private double vartistSekundy;

    public PosekundnyiTarif(string nazva) : base(nazva)
    {
    }

    public double VartistSekundy
    {
        get { return vartistSekundy; }
        set { vartistSekundy = value; }
    }

    public double RozrakhuvatyVartistRozmovy(int kilkistSekund)
    {
        try
        {
            if (kilkistSekund < 0)
            {
                throw new KilkistSekundException("Кількість секунд не може бути від'ємною");
            }

            return kilkistSekund * VartistSekundy;
        }
        catch (KilkistSekundException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return 0;
        }
    }
}

class PohvilynnyiTarif : Tarif
{
    private double vartistHvilyny;

    public PohvilynnyiTarif(string nazva) : base(nazva)
    {
    }

    public double VartistHvilyny
    {
        get { return vartistHvilyny; }
        set { vartistHvilyny = value; }
    }

    public double RozrakhuvatyVartistRozmovy(int kilkistSekund)
    {
        try
        {
            if (kilkistSekund < 0)
            {
                throw new KilkistSekundException("Кількість секунд не може бути від'ємною");
            }

            int kilkistHvilyn = (int)Math.Ceiling(kilkistSekund / 60.0);
            return kilkistHvilyn * VartistHvilyny;
        }
        catch (KilkistSekundException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return 0;
        }
    }
}

class Company
{
    public string Name { get; set; }
    public Tarif Tarif { get; set; }
    public Abonent Abonent { get; set; }

    public Company(string name, Tarif tarif, Abonent abonent)
    {
        Name = name;
        Tarif = tarif;
        Abonent = abonent;
    }
}