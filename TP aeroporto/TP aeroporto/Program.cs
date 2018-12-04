using System;
using System.Collections;
using System.Collections.Generic;

namespace TP_aeroporto
{
    /// <summary>
    /// classe que recebe todos os voos
    /// </summary>
    public class Voo
    {
        
        /// <summary>
        /// recebe o ID(ou numero do VOO)
        /// </summary>
        public int Id { get;  set; }
        /// <summary>
        /// Recebe o destino do VOO
        /// </summary>
        public string Destino { get;  set; }
        /// <summary>
        /// Rebeve o horario do VOO
        /// </summary>
        public DateTime DataHora { get; set; }

        

    }
    /// <summary>
    /// Recebe os dados do Passageiro
    /// </summary>
    public class Passageiro 
    {
        /// <summary>
        /// Nome do Passageiro
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// CPF do passageiro
        /// </summary>
        public long CPF { get; set; }
        /// <summary>
        /// Telefone do Passageiro
        /// </summary>
        public long Telefone { get; set; }
        /// <summary>
        /// Dados do voo do passageiro
        /// </summary>
        public Voo Nvoo { get; set; }
        

    }
    
    class Program
    {
       
        

        static void Main(string[] args)
        {

            //Insere cada destino
            Voo destino1 = new Voo()
            {
                Id = 001,
                Destino = "São Paulo",
                DataHora = Convert.ToDateTime("13:50")
            };
            Voo destino2 = new Voo()
            {
                Id = 002,
                Destino = "Recife",
                DataHora = Convert.ToDateTime("20:00")
            };
            Voo destino3 = new Voo()
            {
                Id = 003,
                Destino = "Rio",
                DataHora = Convert.ToDateTime("21:00")
            };
            //Cria uma lista com os voos
            List<Voo> voos = new List<Voo>();
            voos.Add(destino1);
            voos.Add(destino2);
            voos.Add(destino3);

           

            int posição;
            Queue fila = new Queue();
            List<Passageiro> listaPassageiro = new List<Passageiro>();

            Passageiro passageiro = new Passageiro();

            //Cria passageiros fake (para não ter que cadastras varios ao abrir o programa)
            Passageiro fakepassa1 = new Passageiro()
            {
                Nome = "Eric",
                CPF = 12122121,
                Telefone = 9878987,
                Nvoo = destino1

            };
            Passageiro fakepassa2 = new Passageiro()
            {
                Nome = "Almeida",
                CPF = 120001,
                Telefone = 777784849,
                Nvoo = destino2

            };
            Passageiro fakepassa3 = new Passageiro()
            {
                Nome = "Espirito",
                CPF = 000021,
                Telefone = 51651987,
                Nvoo = destino1

            };
            Passageiro fakepassa4 = new Passageiro()
            {
                Nome = "Santo",
                CPF = 1206501,
                Telefone = 965487987,
                Nvoo = destino3

            };
            //adciona os usuarios a lista e fila
            listaPassageiro.Add(fakepassa1);
            listaPassageiro.Add(fakepassa2);
            listaPassageiro.Add(fakepassa3);
            listaPassageiro.Add(fakepassa4);
            fila.Enqueue(fakepassa1);
            fila.Enqueue(fakepassa2);
            fila.Enqueue(fakepassa3);
            fila.Enqueue(fakepassa4);


            bool sair = false;
            
            do
            {

                string pDestino = "";
                DateTime aux;
                for (int i = 0; i < voos.Count; i++)//define qual é o proximo voo
                {

                    pDestino = destino1.Destino;
                    aux = destino1.DataHora;
                    if (aux > destino2.DataHora)
                    {
                        pDestino = destino2.Destino;
                    }
                    else if (aux > destino3.DataHora)
                    {
                        pDestino = destino3.Destino;
                    }



                }


                Console.WriteLine();
                Console.WriteLine();
               
                Console.WriteLine("Bem vindo ao Aeroporto de Belo Hozironte:\n\n" + "O proximo vou é para: BH/{0}" + "\n\n" +
                    "Menu de Opções\n" +
                    "[F1] Lista de Passageiros\n" +
                    "[F2] Pesquisar\n" +
                    "[F3] Cadastrar Novo Passageiro\n" +
                    "[F4] Excluir Passageiro da lista\n" +
                    "[F5] Mostra Fila de Espera\n" +
                    "[ESC] SAIR",pDestino);

                ConsoleKeyInfo Menu = Console.ReadKey();
                sair = Menu.Key == ConsoleKey.Escape;
                if (Menu.Key == ConsoleKey.F1)//verifica todos os passageiros na fila
                    
                {
                    posição = 1;
                    for (int i = 0; i < fila.Count; i++)
                    {

                        Console.WriteLine("\n" + posição + "°: " + "Nome: {0} " +
                            "CPF: {1} " +
                            "Numero do Voo: {2} " +
                            "Destino: BH/{3} " +
                            "Telefone: {4} " +
                            "Horario: {5}",
                            listaPassageiro[i].Nome, listaPassageiro[i].CPF, listaPassageiro[i].Nvoo.Id, listaPassageiro[i].Nvoo.Destino, listaPassageiro[i].Telefone, listaPassageiro[i].Nvoo.DataHora.TimeOfDay);
                        posição++;
                        Console.WriteLine();
                    }
               
                }
                else if (Menu.Key == ConsoleKey.F2)//pesquisa passageiro expecifico
                {
                    Console.WriteLine("Insira o CPF por favor");
                    int pCPF = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < listaPassageiro.Count && i < 5; i++)
                    {

                        if (pCPF == listaPassageiro[i].CPF)
                        {
                            Console.WriteLine("\n" + "Nome: {0} " +
                            "CPF: {1} " +
                            "Numero do Voo: {2} " +
                            "Destino: BH/{3} " +
                            "Telefone: {4} " +
                            "Horario: {5}",
                            listaPassageiro[i].Nome, listaPassageiro[i].CPF, listaPassageiro[i].Nvoo.Id, listaPassageiro[i].Nvoo.Destino, listaPassageiro[i].Telefone, listaPassageiro[i].Nvoo.DataHora.TimeOfDay);

                            Console.WriteLine();
                        }

                    }
                
                }
                else if (Menu.Key == ConsoleKey.F3)//cadastra um passageiro
                {
                    bool retornar = false;
                    do
                    {
                        Passageiro passageiroCadastro = new Passageiro();


                        Console.WriteLine("Insira seu nome");
                        passageiroCadastro.Nome = Console.ReadLine();

                        Console.WriteLine("Insira seu CPF(APENAS NUMEROS)");
                        passageiroCadastro.CPF = long.Parse(Console.ReadLine());

                        Console.WriteLine("Insira seu Destino\n(RJ para Rio, SP para São Paulo, RE para recife)");
                        string Nvoo = Console.ReadLine();

                        if (Nvoo == "SP")
                        {
                            passageiroCadastro.Nvoo = destino1;
                        }
                        else if (Nvoo == "RE")
                        {
                            passageiroCadastro.Nvoo = destino2;
                        }
                        else if (Nvoo == "RJ")
                        {
                            passageiroCadastro.Nvoo = destino1;
                        }

                        Console.WriteLine("Insira seu Telefone(APENAS NUMEROS)");
                        passageiro.Telefone = long.Parse(Console.ReadLine());

                        

                        listaPassageiro.Add(passageiroCadastro);
                        fila.Enqueue(passageiroCadastro);

                        Console.WriteLine("deseja cadastrar mais um? Caso deseje retornar aperte ESC" );
                        var finalizar = Console.ReadKey();
                        retornar = finalizar.Key == ConsoleKey.Escape;
                        Console.WriteLine();

                    } while (!retornar);











                }
                else if (Menu.Key == ConsoleKey.F4)//remove passageiro da fila
                {
                    fila.Dequeue();

                    Console.WriteLine("\nUsuario removido da fila com sucesso\n");
                    
                }
                else if (Menu.Key == ConsoleKey.F5)
                {
                    posição = 6;
                    for (int i = 0; i > 5 && i < fila.Count; i++)//mostra lista de espera
                    {
                        Console.WriteLine("\n" + posição + "°: " + "Nome: {0} " +
                            "CPF: {1} " +
                            "Numero do Voo: {2} " +
                            "Destino: BH/{3} " +
                            "Telefone: {4} " +
                            "Horario: {5}",
                            listaPassageiro[i].Nome, listaPassageiro[i].CPF, listaPassageiro[i].Nvoo.Id, listaPassageiro[i].Nvoo.Destino, listaPassageiro[i].Telefone, listaPassageiro[i].Nvoo.DataHora.TimeOfDay);
                        posição++;
                        Console.WriteLine();

                    }
                
                }


            } while (!sair);
            
        }









    }
    
}
