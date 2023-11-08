public class ChordMethod
{
    // Делегат для функції, яку будемо апроксимувати
    public delegate double FunctionDelegate(double x);

    // Метод для знаходження кореня рівняння за допомогою методу хорд
    public static double FindRoot(FunctionDelegate func, double a, double b, double epsilon)
    {
        double x0, x1;
        
        // Ініціалізуємо x0 та x1
        x0 = a;
        x1 = b;

        while (Math.Abs(x1 - x0) > epsilon)
        {
            // Обчислюємо значення функції в точках x0 та x1
            double f0 = func(x0);
            double f1 = func(x1);

            // Знаходимо наступне наближення x1
            x1 = x0 - f0 * (x1 - x0) / (f1 - f0);

            // Переміщаємо x0 на попереднє значення x1
            x0 = x1;
        }

        return x1;
    }
}