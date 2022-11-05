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
    }
}