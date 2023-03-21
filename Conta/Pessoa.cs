namespace Conta
{
    internal class Pessoa
    {
        public int Conta { get; private set; } // pode ser visto, mas nao alterado
        public string Nome { get; set; } // podde ser visto e alterado
        public double Saldo { get; private set; } // pode ser visto mas nao alterado (apenas via método)

        public Pessoa(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;            
        }

        public Pessoa(int conta, string nome, double depsaldo) : this(conta, nome)
        {
            Deposito(depsaldo); // 
        }


        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5; // desconta da taxa de saque.
        }

        public override string ToString()
        {
            return "Conta: " + Conta + ", Titular: " + Nome + ", Saldo: R$" + Saldo;
        }

        
    }
}
