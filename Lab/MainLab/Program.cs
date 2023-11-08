class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу ChordMethod для знаходження кореня рівняння x^2 - 4 = 0
        ChordMethod.FunctionDelegate func = x => x * x - 4;
        double a = 0.5;
        double b = 4;
        double epsilon = 1e-6;

        double root = ChordMethod.FindRoot(func, a, b, epsilon);

        Console.WriteLine("Знайдений корінь рівняння: " + root);
    }
}
