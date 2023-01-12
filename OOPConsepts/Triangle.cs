//derived class which actually inherites the  base class shape

class Triangle : Shape
{
    public int Hypertenuese { get; set; }
    //polymorphism
    public override double CalculateArea()
    {
        return 0.5 * Width * Height;
    }
}