using bytebank.Contas;
using bytebank.Titular;

internal class Program
{
    private static void Main(string[] args)
    {
        //ContaCorrente contaDoAndre = new ContaCorrente();
        //contaDoAndre.titular = "André Silva";
        //contaDoAndre.numeroAgencia = 15;
        //contaDoAndre.conta = "1010-X";
        //contaDoAndre.saldo = 100;

        //Console.WriteLine("Saldo da conta do André: " + contaDoAndre.saldo);

        //ContaCorrente contaDoAndre2 = new ContaCorrente();
        //contaDoAndre2.titular = "André Silva";
        //contaDoAndre2.numeroAgencia = 15;
        //contaDoAndre2.conta = "1010-X";
        //contaDoAndre2.saldo = 100;

        //Console.WriteLine("Saldo da conta do André: " + contaDoAndre2.saldo);

        //contaDoAndre = contaDoAndre2;

        //Console.WriteLine(contaDoAndre == contaDoAndre2);

        //ContaCorrente contaDaMaria = new ContaCorrente();
        //contaDaMaria.titular = "Maria Souza";
        //contaDaMaria.numeroAgencia = 17;
        //contaDaMaria.conta = "1010-5";
        //contaDaMaria.saldo = 350;

        //Console.WriteLine("Saldo da conta da Maria: " + contaDaMaria.saldo);

        //contaDoAndre.Transferir(50, contaDaMaria);
        //Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
        //Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

        //ContaCorrente contaDoPedro = new ContaCorrente();
        //Console.WriteLine(contaDoPedro.titular);
        //Console.WriteLine(contaDoPedro.numeroAgencia);
        //Console.WriteLine(contaDoPedro.conta);
        //Console.WriteLine(contaDoPedro.saldo);

        //double valor1 = 300;
        //double valor2 = valor1;

        //Console.WriteLine(valor1 == valor2);
        //Console.WriteLine(valor1);
        //Console.WriteLine(valor2);

        //cliente.nome = "André Souza";
        //cliente.cpf = "12345678900";
        //cliente.profissao = "Analista";

        //ContaCorrente conta = new ContaCorrente();
        //conta.titular = cliente;
        //conta.conta = "1010-X";
        //conta.numeroAgencia = 15;
        //conta.saldo = 100;

        //Console.WriteLine("Titular: {0}", cliente.nome);
        //Console.WriteLine("CPF: {0}", cliente.cpf);
        //Console.WriteLine("Profissão: {0}", cliente.profissao);

        //Console.WriteLine("Nº da conta: {0}", conta.conta);
        //Console.WriteLine("Nº da agência: {0}", conta.numeroAgencia);
        //Console.WriteLine("Saldo atual: {0}", conta.saldo);

        //ContaCorrente conta2 = new ContaCorrente();
        //conta2.titular = new Cliente();
        //conta2.titular.nome = "José Souza";
        //conta2.titular.profissao = "Tester";
        //conta2.titular.cpf = "74839476340";
        //conta2.conta = "9999-X";
        //conta2.numeroAgencia = 18;
        //conta2.saldo = 500;

        //Console.WriteLine(conta2.titular.nome);

        //ContaCorrente conta3 = new ContaCorrente();
        //conta3.Conta = "1011-H";

        //conta3.SetSaldo(200);
        //Console.WriteLine(conta3.GetSaldo());
        //Console.WriteLine(conta3.NumeroAgencia);
        //Console.WriteLine(conta3.Conta);

        //ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
        //conta4.SetSaldo(500);
        //conta4.Titular = new Cliente();

        //Console.WriteLine(conta4.GetSaldo());
        //Console.WriteLine(conta4.NumeroAgencia);

        ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
    }
}