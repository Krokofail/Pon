using Domain.Domain;

namespace Infostructure.Infrastructure;

public sealed class Pow : IPow
{
    public double Invoke(double num, double power)
    {
        return Math.Pow(num, power);
    }
}
