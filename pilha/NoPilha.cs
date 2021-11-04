/*

Estruturas de Dados - Pilha (Classe Nó Pilha)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace Pilha{
    
    class NoPilha<TAD> : Object{

        private TAD elemento;
        private NoPilha<TAD> proximo;

        public NoPilha(){

            proximo = null;
            elemento = default;
        }

        public NoPilha(TAD _elemento, NoPilha<TAD> _proximo){

            elemento = _elemento;
            proximo = _proximo;
        }

        public TAD getElemento(){

            return elemento;
        }

        public void setElemento(TAD _elemento){

            elemento = _elemento;
        }

        public NoPilha<TAD> getProximo(){

            return proximo;
        }

        public void setProximo(NoPilha<TAD> _proximo){

            proximo = _proximo;
        }
    }
}
