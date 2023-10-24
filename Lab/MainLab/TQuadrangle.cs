namespace MainLab
{
    // Базовий клас TQuadrangle
    class TQuadrangle
    {
        protected double[] sides;

        public TQuadrangle(double a, double b, double c, double d)
            => sides = new double[] { a, b, c, d };
        
        public virtual double CalculateArea() => 0;
    
        public virtual double CalculatePerimeter() => 0;
        
        
    }

    // Клас Rectangle, який успадковує TQuadrangle
    class Rectangle : TQuadrangle
    {
        public Rectangle(double length, double width) : base(length, width, length, width)  {}
       

        public override double CalculateArea()
            => sides[0] * sides[1];
            
        public override double CalculatePerimeter()
            => 2 * (sides[0] + sides[1]);
           
    }

    // Клас Square, який успадковує Rectangle
    class Square : Rectangle
    {
        public Square(double side) : base(side, side){}
         
    }

    // Клас Parallelogram, який успадковує TQuadrangle
    class Parallelogram : TQuadrangle
    {
        public Parallelogram(double a, double b, double height) : base(a, b, a, b)
            => Height = height;
                   
        public double Height { get; set; }

        public override double CalculateArea()
            => sides[0] * Height;
        

        public override double CalculatePerimeter()
            => 2 * (sides[0] + sides[1]);
                
    }


}