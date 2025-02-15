﻿using Domain.Domain;

namespace Infostructure.Infrastructure;

public sealed class Addition : IAddition
{
    public double Invoke(double num1, double num2)
    {
        return num1 + num2;
    }
}
