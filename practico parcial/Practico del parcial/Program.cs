using System;

class Program
{
    static void Main()
    {
        // Ejemplo de uso de las funciones

        // Array de enteros
        int[] arrayEnteros = { 5, 8, 2, 1, 9, 4 };

        // Array de cadenas
        string[] arrayCadenas = { "grei", "banana", "manzana", "hoja" };
        string elementoBuscar = "una manzana";

        // Llamar a las funciones y mostrar resultados
        int maximo = CadenaDeEnteros.EncontrarMaximo(arrayEnteros);
        int minimo = CadenaDeEnteros.EncontrarMinimo(arrayEnteros);
        int suma = CadenaDeEnteros.CalcularSuma(arrayEnteros);
        double promedio = CadenaDeEnteros.CalcularPromedio(arrayEnteros);
        bool encontrado = CadenaDeArray.BuscarElemento(arrayCadenas, elementoBuscar);

        int frecuenciaEntero = CadenaDeArray.FrecuenciaElemento(arrayEnteros, 5);
        int frecuenciaCadena = CadenaDeEnteros.FrecuenciaElemento(arrayCadenas, "mi mami");

        string[] complemento = CadenaDeArray.ComplementoArrays(new[] { "super", "bananero", "gualele" }, new[] { "rojo", "amarillo", "verde" });

        int[] equivalenciaAsciiEnteros = CadenaDeEnteros.ObtenerEquivalenciaAscii(new[] {0});
        int[] equivalenciaAsciiCadenas = CadenaDeArray.ObtenerEquivalenciaAscii(new[] { "hey", "muy", "buenas" });

        string[] diferenciaCadenas = CadenaDeArray.DiferenciaArrays(new[] { "como", "estan", "muchacho?" }, new[] { "que tal", "palde", "chicle" });

        string[] arrayInvertido = CadenaDeArray.InvertirArray(new[] { "palabra", "locos", "como?" });
        // Ejemplo para invertir un array de cadenas
        string[] arrayDeCadenas = { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };

        // Invertir el array
        Array.Reverse(arrayDeCadenas);


        // Mostrar resultados en la consola
        Console.WriteLine("1. Máximo: " + maximo);
        Console.WriteLine("   Mínimo: " + minimo);

        Console.WriteLine("\n2. Suma: " + suma);
        Console.WriteLine("\n3. Promedio: " + promedio);

        Console.WriteLine("\n4. ¿Se encontró '" + elementoBuscar + "'? " + (encontrado ? "TRUE" : "FALSE"));

        Console.WriteLine("\n5. Frecuencia del elemento 5 en arrayEnteros: " + frecuenciaEntero);
        Console.WriteLine("\n6. Frecuencia de 'banana' en arrayCadenas: " + frecuenciaCadena);

        Console.WriteLine("\n7. Complemento de dos arrays de cadenas: " + string.Join(", ", complemento));

        Console.WriteLine("\n8. Equivalencia ASCII de arrayEnteros: " + string.Join(", ", equivalenciaAsciiEnteros));
        Console.WriteLine("\n   Equivalencia ASCII de arrayCadenas: " + string.Join(", ", equivalenciaAsciiCadenas));

        Console.WriteLine("\n9. Diferencia entre dos arrays de cadenas: " + string.Join(", ", diferenciaCadenas));

        Console.WriteLine("\n10. Array invertido: " + string.Join(", ", arrayInvertido));
        Console.WriteLine("");
        Console.WriteLine("\n11. Array invertido:");        
        
        foreach (var cadena in arrayDeCadenas)
        {
            Console.WriteLine(cadena);
        }
        string[] arrayA = { "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
        string[] arrayB = { "Dos", "Cuatro", "Seis", "Ocho", "Diez" };

        // Calcular la diferencia B - A
        string[] diferencia = ObtenerDiferencia(arrayB, arrayA);

        // Mostrar la diferencia
        Console.WriteLine("\n12. Diferencia entre B y A:");
        foreach (var item in diferencia)
        {
            Console.WriteLine(item);
        }
        
    }
    static string[] ObtenerDiferencia(string[] arrayB, string[] arrayA)

    {
        // Obtener la diferencia B - A
        var diferencia = new System.Collections.Generic.List<string>(arrayB);
        diferencia.RemoveAll(item => Array.Exists(arrayA, element => element == item));
        return diferencia.ToArray();
    }
}
