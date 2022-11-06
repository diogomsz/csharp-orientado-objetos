namespace bytebank
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public double saldo;
        public string titular;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }

            this.Sacar(valor);
            destino.Depositar(valor);
            return true;
        }
    }
}
