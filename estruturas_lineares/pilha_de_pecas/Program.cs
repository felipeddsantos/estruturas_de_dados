/*

Estruturas de Dados - Pilha de Peças (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;

namespace pilhaDePecas{

    class Program{

        static void Main(string[] args){

            String op;
            String nova, velha;
            bool sair = false;
            Pilha<String> pilha = new Pilha<String>();

            pilha.push("Última peça");
            pilha.push("Outra peça");
            pilha.push("Suporte");
            pilha.push("Hélice");
            pilha.push("Cúpula de vidro");
            pilha.push("Lâmpada");

            while(!sair){

                Console.WriteLine("Insira uma opção:\n");
                Console.WriteLine("[1] - Substituir peça");
                Console.WriteLine("[2] - Imprimir pilha de peças");
                Console.WriteLine("[3] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("Insira a peça nova: ");
                        nova = Console.ReadLine();
                        Console.Write("Insira a peça velha: ");
                        velha = Console.ReadLine();
                        
                        int result = pilha.substituir(nova, velha);

                        if(result == 0)
                        
                            Console.WriteLine("Peça substituída com sucesso.\n");
                        
                        else if(result == 1)

                            Console.WriteLine("Pilha Vazia.\n");

                        else

                            Console.WriteLine("Peça a ser substituída inexistente.\n");
                        
                        break;

                    case "2":
                        
                        pilha.imprimir();
                        Console.Write("\n");
                        break;
                    
                    case "3":
                        
                        sair = true;
                        Console.WriteLine("\nAté logo.");
                        break;
                    
                    default:
                        
                        Console.WriteLine("\nSelecione uma opção válida.\n");
                        break;
                }
            }
        }
    }
}
