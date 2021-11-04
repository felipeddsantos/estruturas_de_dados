/*

Estruturas de Dados - Fila (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;

namespace fila{

    class Program{

        static void Main(string[] args){

            string op;
            int? elemento;
            bool sair = false;
            Fila<int?> fila = new Fila<int?>();
            
            while(!sair){

                Console.WriteLine("Insira uma opção:\n");
                Console.WriteLine("[1] - Inserir elemento na fila");
                Console.WriteLine("[2] - Remover elemento da fila");
                Console.WriteLine("[3] - Ler início da fila");
                Console.WriteLine("[4] - Ler fim da fila");
                Console.WriteLine("[5] - Imprimir fila");
                Console.WriteLine("[6] - Tamanho da fila");
                Console.WriteLine("[7] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        fila.inserirElemento(elemento);
                        Console.WriteLine("Elemento inserido com sucesso: " + elemento + "\n");
                        break;

                    case "2":
                        
                        elemento = fila.removerElemento();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento removido com sucesso: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nFila vazia.\n");
                        
                        break;

                    case "3":
                        
                        elemento = fila.lerInicio();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento do início: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nFila vazia.\n");
                        
                        break;

                    case "4":
                        
                        elemento = fila.lerFim();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento do fim: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nFila vazia.\n");
                        
                        break;

                    case "5":
                        
                        fila.imprimir();
                        break;

                    case "6":
                        
                        Console.WriteLine("\nA fila tem tamanho " + fila.tamanho() + "\n");
                        break;

                    case "7":
                        
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
