namespace CalculatorCore.Infrastructure
{
    public interface IArithmetic
    { double Result(double x, double y); }
    
    public class Div : IArithmetic
    { public double Result(double x, double y) => x / y; }
    
    public class Sub : IArithmetic
    { public double Result(double x, double y) => x - y; }
    
    public class Sum : IArithmetic
    { public double Result(double x, double y) => x + y; }
    
    public class Mult : IArithmetic
    { public double Result(double x, double y) => x * y; }
    
}