using ClasesEstaticas02.Entidades;

namespace ClasesEstaticas02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Binaries And Decimals");
            int nro = 2;
            Console.WriteLine(Conversor.ConvertirDeDecimalBinario(nro));
            string binario = "10";
            Console.WriteLine(Conversor.ConvertirDeBinarioDecimal(binario));
        }
    }
}