using CalculatorCsharp;

namespace Infostructure.Infrastructure;

public sealed class Sqrt : ISqrt
{
    public double Invoke(double num)
    {
        return Math.Sqrt(num);
    }
}
