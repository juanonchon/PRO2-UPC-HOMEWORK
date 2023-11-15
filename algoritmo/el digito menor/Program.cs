namespace DigitoMenor
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

            int menor;

            menor = n1;

            if (menor > n2) menor = n2;
            if (menor > n3) menor = n3;

            Console.WriteLine("El menor de los tres es: " + menor);


            Console.ReadLine();
        }
    }
}
