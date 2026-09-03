using System;

namespace PatosStrategy
{
    // Classe base. Em vez de implementar o "voar" diretamente,
    // o Pato DELEGA esse comportamento para uma estrategia (composicao).
    public class Pato
    {
        // O Pato "tem uma" estrategia de voo (composicao sobre heranca).
        protected IEstrategiaVoo estrategiaVoo;

        public Pato()
        {
            // Comportamento padrao de um pato comum.
            estrategiaVoo = new VoarComAsas();
        }

        // Nao decide COMO voa: apenas delega para a estrategia atual.
        public void Voar()
        {
            estrategiaVoo.Voar();
        }

        // Permite trocar o comportamento de voo em tempo de execucao.
        public void DefinirEstrategiaVoo(IEstrategiaVoo novaEstrategia)
        {
            estrategiaVoo = novaEstrategia;
        }

        // Comportamentos comuns a todos os patos.
        public void Andar()
        {
            Console.WriteLine("Andando de um lado para o outro.");
        }

        public void Mergulhar()
        {
            Console.WriteLine("Mergulhando na agua.");
        }
    }
}
