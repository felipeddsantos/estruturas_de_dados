/*

Estruturas de Dados - Árvore Binária de Busca (Classe Nó Pilha)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

namespace arvoreBinariaDeBusca{

    class NoPilha{

        private NoArvoreBinaria elemento;
        private NoPilha proximo;

        public NoPilha(){

            proximo = null;
        }

        public NoPilha(NoArvoreBinaria _elemento, NoPilha _proximo){

            elemento = _elemento;
            proximo = _proximo;
        }

        public NoArvoreBinaria getElemento(){

            return elemento;
        }

        public void setElemento(NoArvoreBinaria _elemento){

            elemento = _elemento;
        }

        public NoPilha getProximo(){

            return proximo;
        }

        public void setProximo(NoPilha _proximo){

            proximo = _proximo;
        }
    }
}
