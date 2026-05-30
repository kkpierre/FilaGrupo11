using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> fila = new List<Pessoa>();
        string opcao = "";

        Console.WriteLine("=== FILA DO HOSPITAL ===");

        while (opcao != "q")
        {
            Console.WriteLine();
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1 - Cadastrar paciente");
            Console.WriteLine("2 - Listar pacientes");
            Console.WriteLine("q - Sair");
            Console.Write("Opcao: ");

            opcao = Console.ReadLine();
            opcao = opcao.Trim();

            switch (opcao)
            {
                case "1":
                    Pessoa p = new Pessoa();
                    p.Cadastrar();

                    if (p.preferencial == true)
                    {
                        fila.Insert(0, p);
                    }
                    else
                    {
                        fila.Add(p);
                    }

                    Console.WriteLine("Paciente cadastrado.");
                    break;

                case "2":
                    if (fila.Count == 0)
                    {
                        Console.WriteLine("Fila vazia.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("--- FILA ---");

                        int pos = 1;

                        foreach (Pessoa pessoa in fila)
                        {
                            Console.WriteLine(pos + " - " + pessoa.nome);
                            pos = pos + 1;
                        }
                    }
                    break;

                case "q":
                    Console.WriteLine("Encerrando.");
                    break;

                default:
                    Console.WriteLine("Opcao invalida.");
                    break;
            }
        }
    }
}


