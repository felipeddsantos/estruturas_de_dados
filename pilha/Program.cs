/*

Estruturas de Dados - Pilha (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;

namespace Pilha{

    class Program{

        static void Main(string[] args){

            string op;
            int? elemento;
            bool sair = false;
            Pilha<int?> pilha = new Pilha<int?>();
            
            while(!sair){

                Console.WriteLine("Insira uma opção:\n");
                Console.WriteLine("[1] - Inserir elemento na pilha");
                Console.WriteLine("[2] - Remover elemento da pilha");
                Console.WriteLine("[3] - Ler topo da pilha");
                Console.WriteLine("[4] - Imprimir pilha");
                Console.WriteLine("[5] - Tamanho da pilha");
                Console.WriteLine("[6] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        pilha.push(elemento);
                        Console.WriteLine("Elemento inserido com sucesso: " + elemento + "\n");
                        break;

                    case "2":
                        
                        elemento = pilha.pop();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento removido com sucesso: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nPilha vazia.\n");
                        
                        break;

                    case "3":
                        
                        elemento = pilha.lerTopo();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento do topo: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nPilha vazia.\n");
                        
                        break;

                    case "4":
                        
                        pilha.imprimir();
                        break;

                    case "5":
                        
                        Console.WriteLine("\nA pilha tem tamanho " + pilha.tamanho() + "\n");
                        break;

                    case "6":
                        
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
