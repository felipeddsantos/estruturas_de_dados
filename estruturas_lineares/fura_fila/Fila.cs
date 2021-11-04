/*

Estruturas de Dados - Fura-Fila (Classe Fila)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace furaFila{

    class Fila<TAD> : Object{

        private NoFila<TAD> inicio;
        private NoFila<TAD> fim;

        public Fila(){

            inicio = null;
            fim = null;
        }

        public bool eVazia(){

            return inicio == null;
        }

        public int tamanho(){

            if(eVazia())

                return 0;

            int tam = 1;
            NoFila<TAD> temp = inicio;

            while(temp.getProximo() != null){

                tam++;
                temp = temp.getProximo();
            }
            
            return tam;
        }

        public void inserirElemento(TAD elemento){

            NoFila<TAD> novo = new NoFila<TAD>(elemento, null);

            if(eVazia()){
                
                inicio = novo;
                fim = novo;
            }
            
            else{

                fim.setProximo(novo);
                fim = novo;
            }
        }

        public int inserirPosicao(TAD elemento, int posicao){

            if(eVazia())

                return 1;

            NoFila<TAD> novo = new NoFila<TAD>(elemento, null);
            NoFila<TAD> temp = inicio;
            NoFila<TAD> ant = inicio;
            int pos = 0;

            while(temp != null){

                if(pos.Equals(posicao)){

                    if(temp == fim){

                        fim.setProximo(novo);
                        fim = novo;
                    }

                    else{

                        novo.setProximo(temp.getProximo());
                        temp.setProximo(novo);
                    }

                    return 0;
                }

                temp = temp.getProximo();
                pos++;
            }

            return -1;
        }

        public TAD removerElemento(){

            if(eVazia())

                return default;

            TAD temp = inicio.getElemento();
            inicio = inicio.getProximo();
            return temp;
        }

        public void imprimir(){

            if(eVazia())

                Console.WriteLine("\nFila vazia.\n");
            
            else{

                Console.WriteLine("\nStatus atual da fila:");
                
                NoFila<TAD> temp = inicio;

                while(temp != null){

                    Console.Write(temp.getElemento() + " ");
                    temp = temp.getProximo();
                }

                Console.Write("\n");               
            } 
        }
    }
}
