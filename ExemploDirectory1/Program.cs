namespace ExemploDirectory1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string origem = @"c:\temp\origem";
            string destino = @"c:\temp\destino";

            try
            {
                //IEnumerable<string> arquivoTxt = Directory.EnumerateFiles(origem);
                var arquivoTxt = Directory.EnumerateFiles(origem);

                foreach (string arquivo in arquivoTxt) //Pode deixar do tipo var tb
                {
                    /* 
                    * Recupera uma subcadeia de caracteres desta instância. 
                    * A subcadeia de caracteres começa em uma posição de caractere
                    * especificado e continua até o final da cadeia de caracteres.
                    */

                    string nomeArquivo = arquivo.Substring(origem.Length + 1);
                    Directory.Move(arquivo, Path.Combine(destino, nomeArquivo));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro!\n\r" + e.Message);
            }

        }
    }
}