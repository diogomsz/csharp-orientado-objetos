using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            set 
            { 
                if(value > 0)
                {
                    numeroAgencia = value;
                } 
            }
        }

        // private string conta;
        public string Conta { get; set; }

        private double saldo = 100;
        private Cliente titular;

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
    }
}
