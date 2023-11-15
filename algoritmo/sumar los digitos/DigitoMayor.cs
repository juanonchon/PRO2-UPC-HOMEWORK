namespace DigitoMayor
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Escribir un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribir un numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribir un numero: ");
            n3 = int.Parse(Console.ReadLine());

            int mayor;

            mayor = n1;

            if (mayor < n2) mayor = n2;
            if (mayor < n3) mayor = n3;

            Console.WriteLine("El mayor de los tres es: " + mayor);



            Console.ReadLine();
        }
    }
}