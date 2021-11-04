/*

Estruturas de Dados - Lista Crescente (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;

namespace listaCrescente{

    class Program{

        static void Main(string[] args){

            string op;
            int elemento;
            bool sair = false;
            Lista lista = new Lista();
            
            while(!sair){

                Console.WriteLine("Insira uma opção:\n");
                Console.WriteLine("[1] - Inserir elemento em ordem crescente na lista");
                Console.WriteLine("[2] - Remover elemento da lista por posição");
                Console.WriteLine("[3] - Imprimir a lista");
                Console.WriteLine("[4] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        lista.inserirCrescente(elemento);
                        Console.WriteLine("Elemento inserido com sucesso: " + elemento + "\n");
                        break;

                    case "2":
                        
                        Console.Write("\nDigite a posiçao do elemento a ser removido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        int result = lista.removerElemento(elemento);

                        if(result == 1)

                            Console.WriteLine("\nLista vazia.\n");
                        
                        else if(result == 0)

                            Console.WriteLine("Elemento removido com sucesso: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nPosição além do tamanho da lista.\n");

                        break;

                    case "3":
                        
                        lista.imprimir();
                        break;

                    case "4":
                        
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
