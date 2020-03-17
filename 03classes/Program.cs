using System;
using classes.Herança;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 22);

            Ponto3D p2 = new Ponto3D(10, 20, 33);

            Ponto3D.Calcular();//acessando o metodo static
        }
    }
}
