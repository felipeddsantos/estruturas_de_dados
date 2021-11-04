/*

Estruturas de Dados - Lista (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;

namespace lista{

    class Program{

        static void Main(string[] args){

            string op;
            int? elemento;
            bool sair = false;
            Lista<int?> lista = new Lista<int?>();
            
            while(!sair){

                Console.WriteLine("Insira uma opção:\n");
                Console.WriteLine("[1] - Inserir elemento no início da lista");
                Console.WriteLine("[2] - Inserir elemento no fim da lista");
                Console.WriteLine("[3] - Remover elemento da lista");
                Console.WriteLine("[4] - Ler início da lista");
                Console.WriteLine("[5] - Ler fim da lista");
                Console.WriteLine("[6] - Imprimir lista da esquerda para a direita");
                Console.WriteLine("[7] - Imprimir lista da direita para a esquerda");
                Console.WriteLine("[8] - Tamanho da lista");
                Console.WriteLine("[9] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        lista.inserirInicio(elemento);
                        Console.WriteLine("Elemento inserido com sucesso: " + elemento + "\n");
                        break;

                    case "2":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        lista.inserirFim(elemento);
                        Console.WriteLine("Elemento inserido com sucesso: " + elemento + "\n");
                        break;

                    case "3":
                        
                        Console.Write("\nDigite o elemento a ser removido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        int result = lista.removerElemento(elemento);

                        if(result == 1)

                            Console.WriteLine("\nLista vazia.\n");
                        
                        else if(result == 0)

                            Console.WriteLine("Elemento removido com sucesso: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nA lista não possui o elemento procurado.\n");

                        break;

                    case "4":
                        
                        elemento = lista.lerInicio();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento do início: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nLista vazia.\n");
                        
                        break;

                    case "5":
                        
                        elemento = lista.lerFim();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento do fim: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nLista vazia.\n");
                        
                        break;

                    case "6":
                        
                        lista.imprimirInicio();
                        break;

                    case "7":
                        
                        lista.imprimirFim();
                        break;

                    case "8":
                        
                        Console.WriteLine("\nA lista tem tamanho " + lista.tamanho() + "\n");
                        break;

                    case "9":
                        
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
