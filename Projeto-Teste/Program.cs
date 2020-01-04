using System;

namespace Projeto_Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Oi tutupom");
            
            Random rnd = new Random();
            int x = rnd.Next(1, 500);

            int[] vet = new int[x];

            int count = 0;
            //Console.WriteLine("number" + x);

            for (int i = 0; i < x; i++) {
                count++;
                int y = rnd.Next();
                vet[i] = y;
            }

            foreach (int obj in vet) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("contador" + count);
            Console.ReadLine();
        }
    }
}
