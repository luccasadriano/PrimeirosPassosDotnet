using System;

namespace classes.Herança
{
    public class Ponto
    {
        public int x, y;//
        private int distancia;

        public Ponto(int x, int y)//construtor
        {
            this.x = x;//this referencia a classe
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //faz alguma coisa...
        }

        private void CalcularDistancia2()
        {
            //faz alguma coisa...
        }

        public virtual void CalcularDistancia3()
        {
            //faz alguma coisa...
        }
        
    }
}