/*

Estruturas de Dados - Fura-Fila (Classe Nó Fila)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

namespace furaFila{
    
    class NoFila<TAD> : Object{

        private TAD elemento;
        private NoFila<TAD> proximo;

        public NoFila(){

            proximo = null;
            elemento = default;
        }

        public NoFila(TAD _elemento, NoFila<TAD> _proximo){

            elemento = _elemento;
            proximo = _proximo;
        }

        public TAD getElemento(){

            return elemento;
        }

        public void setElemento(TAD _elemento){

            elemento = _elemento;
        }

        public NoFila<TAD> getProximo(){

            return proximo;
        }

        public void setProximo(NoFila<TAD> _proximo){

            proximo = _proximo;
        }
    }
}
