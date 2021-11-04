/*

Estruturas de Dados - Fila (Classe Fila)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace fila{

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

        public TAD lerInicio(){

            if(eVazia())

                return default;
            
            return inicio.getElemento();
        }

        public TAD lerFim(){

            if(eVazia())

                return default;
            
            return fim.getElemento();
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
