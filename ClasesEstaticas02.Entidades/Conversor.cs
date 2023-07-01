namespace ClasesEstaticas02.Entidades
{
    /// <summary>
    /// Clase estática para convertir de decimal a binario y viceversa
    /// </summary>
    public static class Conversor
    {
        public static string ConvertirDeDecimalBinario(int nro)
        {
            return Convert.ToString(nro, 2);
        }
        public static int ConvertirDeBinarioDecimal(string nro)
        {
            return Convert.ToInt32(nro, 2);
        }
    }
}