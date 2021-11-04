/*

Estruturas de Dados - Lista (Classe Nó Lista)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace lista{
    
    class NoLista<TAD> : Object{

        private TAD elemento;
        private NoLista<TAD> proximo;
        private NoLista<TAD> anterior;

        public NoLista(){

            proximo = null;
            anterior = null;
        }

        public NoLista(TAD _elemento, NoLista<TAD> _proximo, NoLista<TAD> _anterior){

            elemento = _elemento;
            proximo = _proximo;
            anterior = _anterior;
        }

        public TAD getElemento(){

            return elemento;
        }

        public void setElemento(TAD _elemento){

            elemento = _elemento;
        }

        public NoLista<TAD> getProximo(){

            return proximo;
        }

        public void setProximo(NoLista<TAD> _proximo){

            proximo = _proximo;
        }

        public NoLista<TAD> getAnterior(){

            return anterior;
        }

        public void setAnterior(NoLista<TAD> _anterior){

            anterior = _anterior;
        }
    }
}
