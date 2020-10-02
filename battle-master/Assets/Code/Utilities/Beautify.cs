using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Beautify
{
    public static string GetAmountWithCurrency(decimal value)
    {
        return $"${value}";
    }
}
