namespace MainLab
{
    // Клас, що представляє тариф з властивістю "Назва".
    public class Tarif
    {
        private string nazva;

        public string Nazva
        {
            get { return nazva; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NazvaException();
                }
                nazva = value;
            }
        }

        // Конструктор класу Tarif, який приймає назву тарифу і перевіряє її на валідність.
        public Tarif(string nazva)
        {
            Nazva = nazva;
        }
    }

    // Клас, який представляє власний виняток для помилок пов'язаних з кількістю секунд.
    public class KilkistSekundException : Exception
    {
        public KilkistSekundException() : base("Кількість секунд не може бути від'ємною.") { }
    }

    // Клас, який представляє власний виняток для помилок пов'язаних з назвою.
    public class NazvaException : Exception
    {
        public NazvaException() : base("Неможливо створити тариф – не вказано назву.") { }
    }


}