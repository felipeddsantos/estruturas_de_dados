/*

Estruturas de Dados - Fura-Fila (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;

namespace furaFila{

    class Program{

        static void Main(string[] args){

            string op;
            int? elemento;
            int pos;
            bool sair = false;
            Fila<int?> fila = new Fila<int?>();
            
            while(!sair){

                Console.WriteLine("Insira uma opção:\n");
                Console.WriteLine("[1] - Inserir elemento na fila");
                Console.WriteLine("[2] - Inserir elemento após uma posição");
                Console.WriteLine("[3] - Remover elemento da fila");
                Console.WriteLine("[4] - Imprimir fila");
                Console.WriteLine("[5] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        fila.inserirElemento(elemento);
                        Console.WriteLine("Elemento inserido com sucesso: " + elemento + "\n");
                        break;

                    case "2":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nDigite a posição: ");
                        pos = Convert.ToInt32(Console.ReadLine());
                        int result = fila.inserirPosicao(elemento, pos);

                        if(result == 0)

                            Console.WriteLine("Elemento inserido com sucesso: " + elemento + "\n");
                        
                        else if(result == 1)

                            Console.WriteLine("Fila vazia.\n");

                        else
                            
                            Console.WriteLine("Posição além das dimensões da fila.\n");

                        break;

                    case "3":
                        
                        elemento = fila.removerElemento();
                        
                        if(elemento != null)
                        
                            Console.WriteLine("\nElemento removido com sucesso: " + elemento + "\n");
                        
                        else

                            Console.WriteLine("\nFila vazia.\n");
                        
                        break;                    

                    case "4":
                        
                        fila.imprimir();
                        break;

                    case "5":
                        
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
