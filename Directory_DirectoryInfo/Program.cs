using System;
using System.IO;
using System.Collections.Generic;

namespace _Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DIRECTORY e DIRECTORYINFO
             - Operações com pastas (create, emumerate, get files, etc.)
             - Directory (possui membros estáticos sendo mais simples e não exigir que seja instanciado um objeto, porém realiza verificação a cada chamada)
             - DirectoryInfo (Necessita que um objeto seja instanciado, porém não realiza verificação)

            * Demonstração:
            - Listar as pastas a partir de uma pasta informada
            - Listar os arquivos a partir de uma pasta informada
            - Criar uma pasta
             */

            string path = @"C:\ProgramasCSharp\ConceitoDeDirectory_DirectoryInfo\Directory_DirectoryInfo\myfolder";

            try
            {
                //EXEMPLO: listagem de pastas apartir de uma pasta informada
                //O tipo IEnumerable é um tipo mais genérico de coleção
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //Lista todas as subpastas apartir da pasta myFolder (*.* = significa (*)qualquer nome de arquivo (.) (*)qualquer extenção. Sendo então uma coleção contendo todas as strings(caminho) para as Subpastas dessa pasta.
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s); //Mostrará as strings que contem o caminho de cada subpasta da pasta myfolder.
                }
                Console.WriteLine();

                //EXEMPLO: Listagem de arquivos a partir de uma pasta informada
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //Lista todas as subpastas apartir da pasta myFolder (*.* = significa (*)qualquer nome de arquivo (.) (*)qualquer extenção. Sendo então uma coleção contendo todas as strings(caminho) para as Subpastas dessa pasta.
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s); //Mostrará as strings que contem o caminho de cada arquivo da pasta myfolder.
                }

                //EXEMPLO: Criar uma pasta
                Directory.CreateDirectory(path + @"\newFolder"); //Cria uma pasta no diretório especificado. Alternativamente pode-se colocar o caminho completo da onde será criada a pasta.
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
