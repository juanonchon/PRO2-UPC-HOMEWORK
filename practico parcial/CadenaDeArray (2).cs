using System;
using System.Linq;

public class CadenaDeArray
{
    public static bool BuscarElemento(string[] array, string elemento)
    {
        return array.Contains(elemento);
    }

    public static int FrecuenciaElemento(int[] array, int elemento)
    {
        return array.Count(e => e == elemento);
    }

    public static string[] ComplementoArrays(string[] arrayA, string[] arrayB)
    {
        return arrayA.Concat(arrayB).Except(arrayA.Intersect(arrayB)).ToArray();
    }

    public static int[] ObtenerEquivalenciaAscii(string[] array)
    {
        return array.Select(s => s.Select(c => (int)c).ToArray()).SelectMany(x => x).ToArray();
    }

    public static string[] DiferenciaArrays(string[] arrayA, string[] arrayB)
    {
        return arrayB.Except(arrayA).ToArray();
    }

    public static string[] InvertirArray(string[] array)
    {
        Array.Reverse(array);
        return array;
    }
}
