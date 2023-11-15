namespace HelloWorld
{
    class Program
    {


        static void Main(string[] args)
        {
            int x = 20;
            int y = 20;
            int z = 20;
            int w = 20;
            int respuesta = sumaDosNumeros(x, y, z, w);
            Console.WriteLine(respuesta);
        }

        static int sumaDosNumeros(int a, int b, int c, int w){
            return a + b + c + w;
            
        }
        
    }
}
