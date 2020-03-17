using System;

namespace _01EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var Pilhar = new Pilha();

            Pilhar.Empilhar(1);
            Pilhar.Empilhar(5);
            Pilhar.Empilhar(10);
            Console.WriteLine(Pilhar.Desempilhar());
            Console.WriteLine(Pilhar.Desempilhar());
            Console.WriteLine(Pilhar.Desempilhar());
            Console.WriteLine(Pilhar.Desempilhar()); //acionando a exception
        }
    }
}
