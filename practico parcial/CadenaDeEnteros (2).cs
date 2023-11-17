using System;
using System.Linq;

public class CadenaDeEnteros
{
    public static int EncontrarMaximo(int[] array)
    {
        return array.Max();
    }

    public static int EncontrarMinimo(int[] array)
    {
        return array.Min();
    }

    public static int CalcularSuma(int[] array)
    {
        return array.Sum();
    }

    public static double CalcularPromedio(int[] array)
    {
        return array.Average();
    }

    public static int FrecuenciaElemento(string[] array, string elemento)
    {
        return array.Count(e => e == elemento);
    }

    public static int[] ObtenerEquivalenciaAscii(int[] array)
    {
        return array.Select(e => (int)e).ToArray();
    }
}
