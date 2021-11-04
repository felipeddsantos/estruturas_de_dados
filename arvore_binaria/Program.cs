/*

Estruturas de Dados - Árvore Binária (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;

namespace arvoreBinaria{

    class Program{

        static void Main(string[] args){

            string op;
            int elemento, resultado;
            bool sair = false;
            ArvoreBinaria arvore = new ArvoreBinaria();
            
            while(!sair){

                Console.WriteLine("Insira uma opção:\n");
                Console.WriteLine("[1] - Inserir elemento na árvore");
                Console.WriteLine("[2] - Remover elemento da árvore");
                Console.WriteLine("[3] - Buscar elemento na árvore");
                Console.WriteLine("[4] - Calcular altura da árvore");
                Console.WriteLine("[5] - Calcular quantidade de nós da árvore");
                Console.WriteLine("[6] - Imprimir árvore pré-ordem");
                Console.WriteLine("[7] - Imprimir árvore em-ordem");
                Console.WriteLine("[8] - Imprimir árvore pós-ordem");
                Console.WriteLine("[9] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        
                        if(arvore.inserir(elemento) == 0)

                            Console.WriteLine("\nElemento inserido com sucesso: " + elemento + ".\n");
                        
                        else

                            Console.WriteLine("\nElemento existente na árvore.\n");
                        
                        break;

                    case "2":

                        Console.Write("\nDigite o elemento a ser removido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());

                        resultado = arvore.remover(elemento);
                        
                        if(resultado == 0)
                        
                            Console.WriteLine("\nElemento removido com sucesso: " + elemento + ".\n");
                        
                        else if(resultado == 1)

                            Console.WriteLine("\nElemento inexistente na árvore.\n");

                        else

                            Console.WriteLine("\nÁrvore vazia.\n");
                        
                        break;

                    case "3":
                        
                        Console.Write("\nDigite o elemento a ser procurado: ");
                        elemento = Convert.ToInt32(Console.ReadLine());

                        resultado = arvore.buscar(elemento);
                        
                        if(resultado == 0)
                        
                            Console.WriteLine("\nElemento existente na árvore.\n");
                        
                        else if(resultado == 1)

                            Console.WriteLine("\nElemento inexistente na árvore.\n");

                        else

                            Console.WriteLine("\nÁrvore vazia.\n");
                        
                        break;

                    case "4":
                        
                        Console.WriteLine("\nA árvore tem altura " + arvore.altura() + ".\n");
                        break;

                    case "5":
                        
                        Console.WriteLine("\nA árvore tem " + arvore.quantidadeNos() + " nós.\n");
                        break;

                    case "6":
                        
                        arvore.imprimirPreOrdem();
                        break;

                    case "7":
                        
                        arvore.imprimirEmOrdem();
                        break;

                    case "8":
                        
                        arvore.imprimirPosOrdem();
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
