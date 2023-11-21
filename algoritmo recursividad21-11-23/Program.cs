namespace recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadLine();

        }
        public static int factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * factorial(n - 1);
            }
            
        }

        
    }
}
