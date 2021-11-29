using System.Globalization;

namespace CalculatorCore.Infrastructure
{
    public interface INumberConvertor
    {
        double Convert(string value);
        string ConvertBack(double value);
    }

    public class NumberConverter : INumberConvertor
    {
        public double Convert(string value)
        {
            double.TryParse(value, out double result);
            return result;
        }

        public string ConvertBack(double value) => $"{value}";
        
    }
}