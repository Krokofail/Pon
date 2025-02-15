﻿using Domain.Domain;

namespace Infostructure.Infrastructure;

public sealed class Multiplication : IMultiplication
{
    public double Invoke(double num1, double num2)
    {
        return num1 * num2;
    }
}
