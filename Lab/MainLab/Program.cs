class Program
{
    static void Main(string[] args)
    {
    
        ChordMethod.FunctionDelegate func = x => x * x - 4;
        double a = 0.5;
        double b = 4;
        double epsilon = 1e-6;

        double root = ChordMethod.FindRoot(func, a, b, epsilon);

        Console.WriteLine("Знайдений корінь рівняння: " + root);
    }
}
