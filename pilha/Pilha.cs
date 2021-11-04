/*

Estruturas de Dados - Pilha (Classe Pilha)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace Pilha{

    class Pilha<TAD> : Object{

        private NoPilha<TAD> topo;

        public Pilha(){

            topo = null;
        }

        public bool eVazia(){

            return topo == null;
        }

        public TAD lerTopo(){

            if(eVazia())

                return default;

            return topo.getElemento();
        }

        public int tamanho(){

            if(eVazia())

                return 0;

            int tam = 1;
            NoPilha<TAD> temp = topo;

            while(temp.getProximo() != null){

                tam++;
                temp = temp.getProximo();
            }
            
            return tam;
        }

        public void push(TAD elemento){

            if(eVazia())
                
                topo = new NoPilha<TAD>(elemento, null);
            
            else{

                NoPilha<TAD> proximo = new NoPilha<TAD>(elemento, topo);
                topo = proximo;
            }
        }

        public TAD pop(){

            if(eVazia())

                return default;

            TAD temp = topo.getElemento();
            topo = topo.getProximo();
            
            return temp;
        }

        public void imprimir(){

            if(eVazia())

                Console.WriteLine("\nPilha vazia.\n");
            
            else{

                Console.WriteLine("\nStatus atual da pilha:");
                
                NoPilha<TAD> temp = topo;

                while(temp != null){

                    Console.WriteLine(temp.getElemento());
                    temp = temp.getProximo();
                }

                Console.Write("\n");
            } 
        }
    }
}
