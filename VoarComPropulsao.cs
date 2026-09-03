using System;

namespace PatosStrategy
{
    // Estrategia concreta: voa com propulsao a jato (ex.: pato de ferro).
    public class VoarComPropulsao : IEstrategiaVoo
    {
        public void Voar()
        {
            Console.WriteLine("Voando com propulsao a jato!");
        }
    }
}
