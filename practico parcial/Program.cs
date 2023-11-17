using System;

class Program
{
    static void Main()
    {

        int[] arrayEnteros = { 4, 2, 7, 1, 9 };
        CadenaDeEnteros cadenaDeEnteros = new CadenaDeEnteros(arrayEnteros);

        cadenaDeEnteros.MostrarMaxMinArrayEnteros();
        Console.WriteLine($"Suma: {cadenaDeEnteros.SumaArrayEnteros()}");
        Console.WriteLine($"Promedio: {cadenaDeEnteros.PromedioArrayEnteros()}");
        Console.WriteLine($"Frecuencia de 2: {cadenaDeEnteros.FrecuenciaArrayEnteros(2)}");

        string[] arrayCadenas = { "uno", "dos", "tres", "cuatro", "cinco" };
        CadenaDeArray cadenaDeArray = new CadenaDeArray(arrayCadenas);

        cadenaDeArray.BuscarElementoArrayCadenas("dos");
        Console.WriteLine($"Frecuencia de 'tres': {cadenaDeArray.FrecuenciaArrayCadenas("tres")}");

        string[] arrayB = { "dos", "cuatro", "seis" };
        cadenaDeArray.ComplementoArrayCadenasAyB(arrayB);
        cadenaDeArray.ArrayCadenasToArrayEnteros();
        cadenaDeArray.DiferenciaArrayCadenasAyB(arrayB);

        cadenaDeArray.InvertirArrayCadenas();

        string[] arrayA = { "uno", "dos", "seis" };
        cadenaDeArray.DiferenciaArrayCadenasByA(arrayA);
    }
}
