/*

Estruturas de Dados - Lista Crescente (Classe Lista)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace listaCrescente{
    
    class NoLista{

        private int elemento;
        private NoLista proximo;
        private NoLista anterior;

        public NoLista(){

            proximo = null;
            anterior = null;
        }

        public NoLista(int _elemento, NoLista _proximo, NoLista _anterior){

            elemento = _elemento;
            proximo = _proximo;
            anterior = _anterior;
        }

        public int getElemento(){

            return elemento;
        }

        public void setElemento(int _elemento){

            elemento = _elemento;
        }

        public NoLista getProximo(){

            return proximo;
        }

        public void setProximo(NoLista _proximo){

            proximo = _proximo;
        }

        public NoLista getAnterior(){

            return anterior;
        }

        public void setAnterior(NoLista _anterior){

            anterior = _anterior;
        }
    }
}
