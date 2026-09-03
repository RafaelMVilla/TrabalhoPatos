namespace PatosStrategy
{
    // STRATEGY: contrato comum para todos os comportamentos de voo.
    // Cada forma de voar (ou nao voar) sera uma classe que implementa esta interface.
    public interface IEstrategiaVoo
    {
        void Voar();
    }
}
