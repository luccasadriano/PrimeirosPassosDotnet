using System;

namespace classes.Metodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y)//ref referencia do metodo
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);//trocando os valores por causa da ref
            System.Console.WriteLine($"{i} {j}"); //Escreve "2 1"
        }
    }
}