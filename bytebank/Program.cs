using bytebank;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaCorrente contaDoAndre = new ContaCorrente();
        contaDoAndre.titular = "André Silva";
        contaDoAndre.numeroAgencia = 15;
        contaDoAndre.conta = "1010-X";
        contaDoAndre.saldo = 100;

        Console.WriteLine("Saldo da conta do André: " + contaDoAndre.saldo);

        ContaCorrente contaDoAndre2 = new ContaCorrente();
        contaDoAndre2.titular = "André Silva";
        contaDoAndre2.numeroAgencia = 15;
        contaDoAndre2.conta = "1010-X";
        contaDoAndre2.saldo = 100;

        Console.WriteLine("Saldo da conta do André: " + contaDoAndre2.saldo);

        contaDoAndre = contaDoAndre2;

        Console.WriteLine(contaDoAndre == contaDoAndre2);

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

        ContaCorrente conta = new ContaCorrente();
    }
}