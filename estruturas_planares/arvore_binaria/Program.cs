/*

Estruturas de Dados - Árvore Binária (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

using System;
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
                Console.WriteLine("[1] - Inserir elemento na árvore binária");
                Console.WriteLine("[2] - Remover elemento da árvore binária");
                Console.WriteLine("[3] - Imprimir árvore binária em ordem crescente de elementos");
                Console.WriteLine("[4] - Calcular quantidade de folhas na árvore binária");
                Console.WriteLine("[5] - Imprimir elementos que possuem dois filhos");
                Console.WriteLine("[6] - Sair");

                op = Console.ReadLine();

                switch(op){

                    case "1":
                        
                        Console.Write("\nDigite o elemento a ser inserido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());
                        
                        if(arvore.inserir(elemento) == 0)

                            Console.WriteLine("\nElemento inserido com sucesso: " + elemento + ".\n");
                        
                        else

                            Console.WriteLine("\nO elemento já existe na árvore binária.\n");
                        
                        break;

                    case "2":

                        Console.Write("\nDigite o elemento a ser removido: ");
                        elemento = Convert.ToInt32(Console.ReadLine());

                        resultado = arvore.remover(elemento);
                        
                        if(resultado == 0)
                        
                            Console.WriteLine("\nElemento removido com sucesso: " + elemento + ".\n");
                        
                        else if(resultado == 1)

                            Console.WriteLine("\nO elemento não existe na árvore binária.\n");

                        else

                            Console.WriteLine("\nÁrvore binária vazia.\n");
                        
                        break;

                    case "3":
                        
                        Console.WriteLine("\nElementos da árvore binária em ordem crescente:");
                        arvore.imprimirOrdemCrescente();
                        Console.WriteLine("\n");
                        break;

                    case "4":
                        
                        Console.WriteLine("\nA árvore binária tem " + arvore.quantidadeFolhas() + " folhas.\n");
                        break;

                    case "5":
                        
                        Console.WriteLine("\nElementos da árvore binária que possuem dois filhos:");
                        arvore.imprimirNosDoisFilhos();
                        Console.WriteLine("\n");
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
