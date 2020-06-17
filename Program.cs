using System;

namespace Dojo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip bilhete = new IngressoVip();
            bilhete.Valor = 16.99f;
            bilhete.ImprimirValor();
            bilhete.ValorAdicional = 12.0f;
            bilhete.AdicionarValor();
            System.Console.WriteLine();
            System.Console.WriteLine("A diferença de valores para os dois ingressos é: {0}",bilhete.ValorAdicional);

        }
    }
}
