using System;

namespace URI_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while(x != 0 || y !=  0){
                if (x >  0 && y > 0){
                    Console.WriteLine("primeiro");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                    
                }
                else if (x < 0 && y >0){
                    Console.WriteLine("segundo");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }
                else if (x < 0 && y < 0){
                    Console.WriteLine("terceiro");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }
                else{
                    Console.WriteLine("quarto");
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }
            }
            
        }
    }
}
