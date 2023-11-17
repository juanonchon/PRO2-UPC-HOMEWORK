using System;
using System.Linq;

public class CadenaDeArray
{
    private string[] arrayCadenas;

    public CadenaDeArray(string[] arrayCadenas)
    {
        this.arrayCadenas = arrayCadenas;
    }

    public void BuscarElementoArrayCadenas(string elemento)
    {
        bool encontrado = arrayCadenas.Contains(elemento);
        Console.WriteLine(encontrado ? "TRUE" : "FALSE");
    }

    public int FrecuenciaArrayCadenas(string elemento)
    {
        return arrayCadenas.Count(x => x == elemento);
    }

    public void ComplementoArrayCadenasAyB(string[] arrayB)
    {
        var complemento = arrayCadenas.Except(arrayB).ToArray();
        Console.WriteLine(string.Join(", ", complemento));
    }

    public void ArrayCadenasToArrayEnteros()
    {
        var arrayEnteros = arrayCadenas.Select(s => (int)s[0]).ToArray();
        Console.WriteLine(string.Join(", ", arrayEnteros));
    }

    public void DiferenciaArrayCadenasAyB(string[] arrayB)
    {
        var diferencia = arrayCadenas.Except(arrayB).ToArray();
        Console.WriteLine(string.Join(", ", diferencia));
    }

    public void InvertirArrayCadenas()
    {
        Array.Reverse(arrayCadenas);
        Console.WriteLine(string.Join("lol, ", arrayCadenas));
    }

    public void DiferenciaArrayCadenasByA(string[] arrayA)
    {
        var diferencia = arrayCadenas.Except(arrayA).ToArray();
        Console.WriteLine(string.Join(", ", diferencia));
    }
}
