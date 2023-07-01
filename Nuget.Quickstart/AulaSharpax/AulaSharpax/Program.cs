//*using System;*/
using System.Drawing;

namespace AulaSharpax
{
    public class Carteira
    {
        public int dinheiro = 100;
        private int num;
        private int valor;

        public void Acrescentar (in valor)
        {
            dinheiro += valor;

        }

        public void Retirar(int valor)
        {
            dinheiro -= valor;

        }

        public int MostrarDinheiro()
        {
            return dinheiro;
        }

        public void AlterarDinheiro(int numn)
        {
            dinheiro = num;
        }

        public static implicit operator Carteira(int v)
        {
            throw new NotImplementedException();
        }
    }

    public class Joao
    {
        static void Main(string args[])
        {
            Carteira cart = new Carteira();
            Carteira dinheiro = 10;
            Console.WriteLine("O saldo agora é: " + cart.dinheiro);
        }
    }

}