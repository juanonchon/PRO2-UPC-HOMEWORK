namespace Programacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {

           DominoRecursiv0(A,B);
        }   
        static int A = 0;
        static int B = 7;
        public static void DominoRecursiv0(int A, int B){
            if(A == 0){

            }
            if(B == 0)
            
            {
                return;
            }else{
                int serieA = A + 1;
                Console.WriteLine("SerieA: " + serieA);
                A = serieA;  

                int serieB = B - 1;
                Console.WriteLine("SerieB: " + serieB);
                B = serieB;  
                DominoRecursiv0(A, B);   
            }
            
        }
    }

}