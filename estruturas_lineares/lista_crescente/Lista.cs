/*

Estruturas de Dados - Lista Crescente (Classe Lista)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace listaTemplate{

    class Lista{

        private NoLista inicio;
        private NoLista fim;

        public Lista(){

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
            NoLista temp = inicio;

            while(temp.getProximo() != null){

                tam++;
                temp = temp.getProximo();
            }
            
            return tam;
        }

        public void inserirCrescente(int elemento){

            NoLista novo = new NoLista(elemento, null, null);

            if(eVazia()){

                inicio = novo;
                fim = novo;
            }
            
            else{

                NoLista temp = inicio;

                while(temp != null){

                    if(elemento <= temp.getElemento()){

                        if(temp == inicio){
                                        
                            novo.setProximo(inicio);
                            inicio.setAnterior(novo);
                            inicio = novo;
                            break;
                        }

                        else{

                            novo.setProximo(temp);
                            novo.setAnterior(temp.getAnterior());
                            temp.getAnterior().setProximo(novo);
                            temp.setAnterior(novo);
                            break;
                        }
                    }

                    else if(temp == fim){

                            novo.setAnterior(fim);
                            fim.setProximo(novo);
                            fim = novo;
                            break;
                    }

                    temp = temp.getProximo();
                }
            }
        }

        public int removerElemento(int posicao){

            if(eVazia())

                return 1;
            
            NoLista temp = inicio;
            int pos = 0;

            while(temp != null){

                if(posicao == pos){

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
                pos++;
            }

            return -1;
        }

        public void imprimir(){

            if(eVazia())

                Console.WriteLine("\nLista vazia.\n");
            
            else{

                Console.WriteLine("\nStatus atual da lista, da esquerda para a direita: ");
                
                NoLista temp = inicio;

                while(temp != null){

                    Console.Write(temp.getElemento() + " ");
                    temp = temp.getProximo();
                }

                Console.Write("\n");
            } 
        }
    }
}
