using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            private set 
            { 
                if(value > 0)
                {
                    numeroAgencia = value;
                }
            }
        }

        private double saldo = 100;
        public string Conta { get; set; } // private string conta;
        public Cliente Titular { get; set; } //private Cliente titular;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }

            Sacar(valor);
            destino.Depositar(valor);
            return true;
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }

            this.saldo = valor;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
            TotalDeContasCriadas++;
        }

    }
}
