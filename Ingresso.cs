namespace Dojo_2
{
    public class Ingresso
    {

        public float Valor { get; set; }
        public void ImprimirValor(){
            System.Console.WriteLine($"\nVocê irá pagar {Valor} no ingresso convencional\n");
        }
    }
}