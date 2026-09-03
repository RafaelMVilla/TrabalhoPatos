using System;

namespace PatosStrategy
{
    // Estrategia concreta: voa batendo as asas.
    public class VoarComAsas : IEstrategiaVoo
    {
        public void Voar()
        {
            Console.WriteLine("Estou voando batendo as asas!");
        }
    }
}
