using System;

namespace PatosStrategy
{
    // Herda de Pato e voa de um jeito totalmente diferente.
    public class PatoDeFerro : Pato
    {
        public PatoDeFerro()
        {
            // Pato de ferro voa com propulsao a jato.
            estrategiaVoo = new VoarComPropulsao();
        }

        public void Queimar()
        {
            Console.WriteLine("Esquentando o metal... o pato de ferro esta queimando!");
        }
    }
}
