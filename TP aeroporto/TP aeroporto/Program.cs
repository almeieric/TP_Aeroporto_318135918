using System;
using System.Collections;
using System.Collections.Generic;

namespace TP_aeroporto
{
    public class Passageiro
    {
        public string Nome { get; set; }
        public int Nvoo { get; set; }
        public int Npassagem { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set; }
        public int Horario { get; set; }

        
    }

    
    class Program
    {
        //static List<Passageiro> lista = new List<Passageiro>();
        
        
             
        
        
        static void Main(string[] args)
        {
            //Queue fila = new Queue();
            List<Passageiro> lista = new List<Passageiro>();
            Passageiro passageiro = new Passageiro();
            bool sair = false;
            do
            {
                Console.WriteLine("Bem vindo ao Aeroporto do Acre:\n" +
                    "Menu de Opções\n" +
                    "[F1] Lista de Passageiros\n" +
                    "[F2] Pesquisar\n" +
                    "[F3] Cadastrar Novo Passageiro\n" +
                    "[F4] Excluir Passageiro da lista\n" +
                    "[F5] Mostra Fila de Espera\n" +
                    "[ESC] SAIR");

                ConsoleKeyInfo Menu = Console.ReadKey();
                sair = Menu.Key == ConsoleKey.Escape;
                if (Menu.Key == ConsoleKey.F1)
                {
                    int posição = 1;
                    for (int i = 0; i < lista.Count; i++)
                    {
                        Console.WriteLine(posição + "°: " + "Nome: {0} " +
                            "CPF: {1} " +
                            "Numero do Voo: {2} " +
                            "Numero da Passagem: {3} " +
                            "Telefone: {3} " +
                            "Horario: {4}",
                            lista[i].Nome, lista[i].CPF, lista[i].Nvoo, lista[i].Npassagem, lista[i].Telefone, lista[i].Horario);
                        posição++;
                        Console.WriteLine();
                    }
                }
                else if (Menu.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Insira o CPF por favor");
                    int pCPF = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < lista.Count; i++)
                    {

                        if (pCPF == passageiro.CPF)
                        {
                            Console.WriteLine("Nome: {0} " +
                                "CPF: {1} " +
                                "Numero do Voo: {2} " +
                                "Numero da Passagem: {3} " +
                                "Telefone: {3} " +
                                "Horario: {4}",
                                lista[i].Nome, lista[i].CPF, lista[i].Nvoo, lista[i].Npassagem, lista[i].Telefone, lista[i].Horario);

                            Console.WriteLine();
                        }

                    }
                }
                else if (Menu.Key == ConsoleKey.F3)
                {
                    bool retornar = false;
                    do
                    {
                        Console.WriteLine("Insira seu nome");
                        passageiro.Nome = Console.ReadLine();

                        Console.WriteLine("Insira seu CPF(não insira pontuação)");
                        passageiro.CPF = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Insira seu Numero do Voo(não insira pontuação)");
                        passageiro.Nvoo = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Insira seu Numero de passagem(não insira pontuação)");
                        passageiro.Npassagem = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Insira seu Telefone(não insira pontuação)");
                        passageiro.Telefone = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Insira seu Horario(não insira pontuação)");
                        passageiro.Horario = Int32.Parse(Console.ReadLine());

                        
                        lista.Add(passageiro);
                        

                        Console.WriteLine("deseja cadastrar mais um?(Caso deseje retornar aperte F6)");
                        var finalizar = Console.ReadKey();
                        retornar = finalizar.Key == ConsoleKey.F6;

                    } while (!retornar);











                }
                else if (Menu.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Aqui Mostra a fila de espera");
                }



            } while (!sair);

            
        }

        
    }
}
