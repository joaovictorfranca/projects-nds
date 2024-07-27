using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace TextEditor
{
    class Program
    {
        static string diretorioPadrao = "/home/joaovictorsilva/Área de Trabalho/Texto/"; // Diretório padrão para salvar e abrir arquivos

        static void Main(string[] args)
        {
            if (!Directory.Exists(diretorioPadrao))
            {
                Directory.CreateDirectory(diretorioPadrao);
            }

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("3 - Excluir arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 3: Excluir(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Arquivos existentes no diretório padrão:");
            List<string> arquivos = ListarArquivos();
            foreach (string arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("Qual nome do arquivo que deseja abrir?");
            string nomeArquivo = Console.ReadLine();

            string caminhoArquivo = Path.Combine(diretorioPadrao, nomeArquivo);

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo não encontrado!");
                Console.ReadLine();
                Menu();
                return;
            }

            Console.Clear();
            string texto = File.ReadAllText(caminhoArquivo);
            Console.WriteLine(texto);

            Console.WriteLine("-------------------");
            Console.ReadLine();
            Menu();
        }

        static void Excluir()
        {
            Console.Clear();
            Console.WriteLine("Arquivos existentes no diretório padrão:");
            List<string> arquivos = ListarArquivos();
            foreach (string arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("Qual o nome do arquivo que você deseja excluir?");
            string nomeArquivo = Console.ReadLine();

            string caminhoArquivo = Path.Combine(diretorioPadrao, nomeArquivo);

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo não encontrado!");
                Console.ReadLine();
                Menu();
                return;
            }

            File.Delete(caminhoArquivo);
            Console.WriteLine($"Arquivo {nomeArquivo} excluído com sucesso.");
            Console.ReadLine();
            Menu();
        }


        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (F1 para sair)");

            StringBuilder texto = new StringBuilder();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.F1)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    texto.AppendLine();
                    Console.WriteLine();
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (texto.Length > 0)
                    {
                        texto.Remove(texto.Length - 1, 1);
                        Console.Write("\b \b"); // Apaga o caractere na tela
                    }
                }
                else
                {
                    texto.Append(key.KeyChar);
                    Console.Write(key.KeyChar);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Para salvar pressione F2");
            if (Console.ReadKey().Key == ConsoleKey.F2)
            {
                Salvar(texto.ToString());
            }

            Console.Clear();
        }


        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual nome do arquivo para salvar?");
            string nomeArquivo = Console.ReadLine();

            string caminhoArquivo = Path.Combine(diretorioPadrao, nomeArquivo);

            using (var file = new StreamWriter(caminhoArquivo))
            {
                file.Write(texto);
            }

            Console.WriteLine($"Arquivo salvo com sucesso em {caminhoArquivo}");
            Console.ReadLine();
            Menu();
        }

        static void AbrirLinks(string texto)
        {
            Console.WriteLine("Links encontrados:");
            foreach (Match match in Regex.Matches(texto, @"\b(?:file://)?\w+(?:\.|\w|/)+\b"))
            {
                string link = match.Value.Replace("file://", "");
                if (File.Exists(link))
                {
                    AbrirLink(link);
                }
                else
                {
                    Console.WriteLine($"O arquivo {link} não existe.");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }


        static void AbrirLink(string link)
        {
            try
            {
                Process.Start("xdg-open", link);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir o link {link}: {ex.Message}");
            }
        }

        static List<string> ListarArquivos()
        {
            string[] arquivos = Directory.GetFiles(diretorioPadrao);
            List<string> nomesArquivos = new List<string>();

            foreach (string arquivo in arquivos)
            {
                nomesArquivos.Add(Path.GetFileName(arquivo));
            }

            return nomesArquivos;
        }

    }
}
