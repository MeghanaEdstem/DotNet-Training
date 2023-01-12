/* 
namespace OOPConsepts
{
    internal class Class2
    {
        //empty default constructor
    }
}
*/
//base class
abstract class Shape : IShape
{
    public int Height { get; set; }
    public int Width { get; set; }
    public virtual double CalculateArea()
    {
        return Width * Height;
    }
}
