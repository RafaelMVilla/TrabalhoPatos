using System;

namespace PatosStrategy
{
    // Herda de Pato, mas usa uma estrategia de voo diferente.
    public class PatoDeBorracha : Pato
    {
        public PatoDeBorracha()
        {
            // Pato de borracha nao voa: basta injetar a estrategia certa.
            estrategiaVoo = new NaoVoar();
        }

        public void MudarSkin()
        {
            Console.WriteLine("Trocando a cor/skin do pato de borracha.");
        }
    }
}
