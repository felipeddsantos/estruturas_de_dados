/*

Estruturas de Dados - Pilha de Peças (Classe Pilha)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace pilhaDePecas{

    class Pilha<TAD> : Object{

        private NoPilha<TAD> topo;

        public Pilha(){

            topo = null;
        }

        public bool eVazia(){

            return topo == null;
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

        public int substituir(TAD nova_peca, TAD velha){

            if(eVazia())

                return 1;

            NoPilha<TAD> temp = topo;
            NoPilha<TAD> anterior = topo;
            NoPilha<TAD> nova = new NoPilha<TAD>(nova_peca, null);

            while(temp != null){

                if(temp.getElemento().Equals(velha)){

                    if(temp == topo){

                        nova.setProximo(topo.getProximo());
                        topo = nova;
                    }

                    else{

                        nova.setProximo(temp.getProximo());
                        anterior.setProximo(nova);
                    }

                    return 0;
                }

                anterior = temp;
                temp = temp.getProximo();
            }

            return -1;
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
