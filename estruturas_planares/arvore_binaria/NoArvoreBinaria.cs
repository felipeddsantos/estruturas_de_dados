/*

Estruturas de Dados - Árvore Binária (Classe Nó Árvore Binária)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

using System;

namespace arvoreBinaria{
    
    class NoArvoreBinaria{

        private int valor;
        private NoArvoreBinaria esquerda;
        private NoArvoreBinaria direita;

        public NoArvoreBinaria(){

            esquerda = null;
            direita = null;
        }

        public NoArvoreBinaria(int _valor){

            valor = _valor;
        }

        public int getValor(){

            return valor;
        }

        public void setValor(int _valor){

            valor = _valor;
        }

        public NoArvoreBinaria getEsquerda(){

            return esquerda;
        }

        public void setEsquerda(NoArvoreBinaria _esquerda){

            esquerda = _esquerda;
        }
        public NoArvoreBinaria getDireita(){

            return direita;
        }

        public void setDireita(NoArvoreBinaria _direita){

            direita = _direita;
        }
    }
}
