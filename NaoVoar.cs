using System;

namespace PatosStrategy
{
    // Estrategia concreta: nao voa (ex.: pato de borracha).
    public class NaoVoar : IEstrategiaVoo
    {
        public void Voar()
        {
            Console.WriteLine("Nao sei voar...");
        }
    }
}
