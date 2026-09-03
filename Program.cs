using System;

namespace PatosStrategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Pato comum ===");
            Pato pato = new Pato();
            pato.Andar();
            pato.Mergulhar();
            pato.Voar();                       // Estou voando batendo as asas!

            Console.WriteLine("\n=== Pato de Borracha ===");
            PatoDeBorracha patoBorracha = new PatoDeBorracha();
            patoBorracha.Andar();
            patoBorracha.MudarSkin();
            patoBorracha.Voar();               // Nao sei voar...

            Console.WriteLine("\n=== Pato de Ferro ===");
            PatoDeFerro patoFerro = new PatoDeFerro();
            patoFerro.Queimar();
            patoFerro.Voar();                  // Voando com propulsao a jato!

            Console.WriteLine("\n=== Trocando a estrategia em tempo de execucao ===");
            patoBorracha.Voar();                            // Nao sei voar...
            patoBorracha.DefinirEstrategiaVoo(new VoarComAsas());
            patoBorracha.Voar();                            // Agora voa batendo as asas!
        }
    }
}
