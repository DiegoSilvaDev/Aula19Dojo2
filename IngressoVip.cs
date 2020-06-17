using System;
namespace Dojo_2
{
    public class IngressoVip : Ingresso
    {
        public float ValorAdicional { get; set; }
        public void AdicionarValor(){
            float vip = Valor + ValorAdicional;
            Console.ForegroundColor = ConsoleColor.Red; 
            System.Console.WriteLine($"O valor do ingresso Vip é {vip}");
            Console.ResetColor();
        }
    }
}