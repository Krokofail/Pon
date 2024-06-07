using Domain.Domain;

namespace Infostructure.Infrastructure;

public sealed class Cos : ICos
{
    public double Invoke(double num)
    {
        return Math.Cos(num);
    }
}
