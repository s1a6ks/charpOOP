using System.Net.Mail;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        PosekundnyiTarif posekundnyiTarif = new PosekundnyiTarif("posecund");
        posekundnyiTarif.VartistSekundy = 0.05;
        double vartistRozmovy = posekundnyiTarif.RozrakhuvatyVartistRozmovy(100);
        Console.WriteLine($"Вартість розмови посекундно: {vartistRozmovy}");

        try
        {
            Tarif tarif = new Tarif(null);
        }
        catch (NazvaException ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        PohvilynnyiTarif pohvilynnyiTarif = new PohvilynnyiTarif("pohvilin");
        Abonent abonent = new Abonent("Goretsky M.I.", "0678761694", 150.00);
        Company company = new Company("company", pohvilynnyiTarif, abonent);
        Console.WriteLine($"Company: {company.Name}, Tarif: {company.Tarif.Nazva}\nAbonent: {company.Abonent.PIB}, {company.Abonent.NomerTelefonu}, balance: {company.Abonent.ZalishokNaRahunku}");
    }
}