using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospital
{
    using System;

    /* class Program
    {
        static void Main()
        {

            int tamanhoFila = 3;
            string[] fila = new string[tamanhoFila];
            int contador = 0;

            while (contador < tamanhoFila)
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite seu telefone: ");
                string telefone = Console.ReadLine();
                Console.Write("Digite seu CPF:");
                string CPF = Console.ReadLine();

                fila[contador] = nome;
                contador++;

                Console.WriteLine("\nVocê está na fila de espera.\n");
            }

            Console.WriteLine("\nFila de pacientes:");
            for (int i = 0; i < fila.Length; i++)
            {
                Console.WriteLine($"Posição {i + 1}: {fila[i]}");
            }

            Console.WriteLine("\nPressione Q para sair...");
            Console.ReadKey();

        }
    }*/


    class Program
    {
        static void Main(string[] args)
        {
            string[] fila = new string[11];
            int contador = 0;

            while (true)
            {
                Console.WriteLine("1 - Cadastrar paciente");
                Console.WriteLine("2 - Inserir na fila");
                Console.WriteLine("3 - Listar pacientes");
                Console.WriteLine("4 - Atender paciente");
                Console.WriteLine("q - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "q")
                {
                    break;
                }

                if (opcao == "1")
                {
                    if (contador < fila.Length)
                    {
                        Console.Write("Nome do paciente: ");
                        fila[contador] = Console.ReadLine();
                        contador++;
                        Console.WriteLine("Paciente cadastrado!");
                    }
                    else
                    {
                        Console.WriteLine("Fila cheia");
                    }
                }
                else if (opcao == "2")
                {
                    if (contador < fila.Length)
                    {
                        Console.Write("Nome do paciente: ");
                        fila[contador] = Console.ReadLine();
                        contador++;
                        Console.WriteLine("Paciente na fila!");
                    }
                    else
                    {
                        Console.WriteLine("Fila cheia!");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Pacientes na fila:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(fila[i]);
                    }
                }
                else if (opcao == "4")
                {
                    if (contador > 0)
                    {
                        Console.WriteLine($"Atendendo: {fila[0]}");
                        for (int i = 0; i < contador - 1; i++)
                        {
                            fila[i] = fila[i + 1];
                        }
                        contador--;
                    }
                    else
                    {
                        Console.WriteLine("Sem pacientes.");
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }

                Console.WriteLine();
            }
        }
    }
}
