/*

Estruturas de Dados - Lista (Classe Lista)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace lista{

    class Lista<TAD> : Object{

        private NoLista<TAD> inicio;
        private NoLista<TAD> fim;

        public Lista(){

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
            NoLista<TAD> temp = inicio;

            while(temp.getProximo() != null){

                tam++;
                temp = temp.getProximo();
            }
            
            return tam;
        }

        public void inserirInicio(TAD elemento){

            if(eVazia()){
                
                NoLista<TAD> novo = new NoLista<TAD>(elemento, null, null);
                inicio = novo;
                fim = novo;
            }
            
            else{

                NoLista<TAD> novo = new NoLista<TAD>(elemento, inicio, null);
                inicio.setAnterior(novo);
                inicio = novo;
            }
        }

        public void inserirFim(TAD elemento){

            if(eVazia()){
                
                NoLista<TAD> novo = new NoLista<TAD>(elemento, null, null);
                inicio = novo;
                fim = novo;
            }
            
            else{

                NoLista<TAD> novo = new NoLista<TAD>(elemento, null, fim);
                fim.setProximo(novo);
                fim = novo;
            }
        }

        public int removerElemento(TAD elemento){

            if(eVazia())

                return 1;
            
            NoLista<TAD> temp = inicio;

            while(temp != null){

                TAD e = temp.getElemento();

                if(e.Equals(elemento)){

                    if(tamanho() == 1){

                        inicio = null;
                        fim = null;
                    }

                    else if(temp == inicio){

                        inicio = inicio.getProximo();
                        inicio.setAnterior(null);
                    }

                    else if(temp == fim){

                        fim = fim.getAnterior();
                        fim.setProximo(null);
                    }

                    else{

                        temp.getAnterior().setProximo(temp.getProximo());
                        temp.getProximo().setAnterior(temp.getAnterior());
                    }

                    return 0;
                }

                temp = temp.getProximo();
            }

            return -1;
        }

        public void imprimirInicio(){

            if(eVazia())

                Console.WriteLine("\nLista vazia.\n");
            
            else{

                Console.WriteLine("\nStatus atual da lista, da esquerda para a direita: ");
                
                NoLista<TAD> temp = inicio;

                while(temp != null){

                    Console.Write(temp.getElemento() + " ");
                    temp = temp.getProximo();
                }

                Console.Write("\n");
            } 
        }

        public void imprimirFim(){

            if(eVazia())

                Console.WriteLine("\nLista vazia.\n");
            
            else{

                Console.WriteLine("\nStatus atual da lista, da direita para a esquerda: ");
                
                NoLista<TAD> temp = fim;

                while(temp != null){

                    Console.Write(temp.getElemento() + " ");
                    temp = temp.getAnterior();
                }

                Console.Write("\n");
            } 
        }
    }
}
