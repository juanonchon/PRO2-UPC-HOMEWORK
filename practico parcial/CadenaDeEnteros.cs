using System;
using System.Linq;

public class CadenaDeEnteros
{
    private int[] arrayEnteros;

    public CadenaDeEnteros(int[] arrayEnteros)
    {
        this.arrayEnteros = arrayEnteros;
    }

    public void MostrarMaxMinArrayEnteros()
    {
        int maximo = arrayEnteros.Max();
        int minimo = arrayEnteros.Min();

        Console.WriteLine($"Máximo: {maximo}, Mínimo: {minimo}");
    }

    public int SumaArrayEnteros()
    {
        return arrayEnteros.Sum();
    }

    public int PromedioArrayEnteros()
    {
        return (int)arrayEnteros.Average();
    }

    public int FrecuenciaArrayEnteros(int elemento)
    {
        return arrayEnteros.Count(x => x == elemento);
    }
}
