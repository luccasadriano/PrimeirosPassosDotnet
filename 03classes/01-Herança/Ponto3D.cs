using System;

namespace classes.Herança
{
    public class Ponto3D : Ponto//herdando de outra classe
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x ,y)//passando o X, Y da classe ponto
        {
            this.z = z;
            CalcularDistancia();
            //sem acesso ao CalcularDistancia2 (classes filhas) pois esta como private
        }

        public static void Calcular()
        {
            //faz alguma coisa...
        }
        public override void CalcularDistancia3()//override sobrescreva o metodo CalcularDistancia3
        {
            //faz alguma coisa...
        }
    }
}