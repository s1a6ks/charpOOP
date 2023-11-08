namespace MainLab
{
    using System;
    using System.Collections.Generic;

    // Оголошуємо інтерфейс IShape, який містить методи та властивість для роботи з фігурами.
    public interface IShape
    {
        void DisplayShapeType();  // Метод виведення типу фігури.
        void DisplayArea();       // Метод виведення площі фігури.
        double FirstDimension { get; set; }  // Перший лінійний розмір фігури.
    }

    // Оголошуємо інтерфейс IColoredShape, який успадковує IShape та додає колір фігури.
    public interface IColoredShape : IShape
    {
        string Color { get; set; }  // Властивість для кольору фігури.
        void DisplayColor();        // Метод виведення кольору фігури.
    }

    // Клас Circle реалізує інтерфейс IShape і містить властивість Radius.
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public void DisplayShapeType()
        {
            Console.WriteLine("Shape Type: Circle");
        }

        public void DisplayArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Area: {area}");
        }

        public double FirstDimension
        {
            get { return Radius; }
            set { Radius = value; }
        }
    }

    // Клас ColoredCircle успадковує Circle і реалізує IColoredShape, додаючи властивість Color.
    public class ColoredCircle : Circle, IColoredShape
    {
        public string Color { get; set; }

        public void DisplayColor()
        {
            Console.WriteLine($"Color: {Color}");
        }
    }
    public static class PrintShapes
    {
        // Метод ProcessShapes приймає список фігур та викликає методи виведення типу, площі та кольору для кольорових фігур.
        public static void ProcessShapes(List<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.DisplayShapeType();
                shape.DisplayArea();

                if (shape is IColoredShape coloredShape)
                {
                    coloredShape.DisplayColor();
                }

                Console.WriteLine();
            }
        }
    }
}