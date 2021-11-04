/*

Estruturas de Dados - Árvore Binária de Busca (Classe Nó Fila)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

namespace arvoreBinariaDeBusca{

    class NoFila{

        private NoArvoreBinaria elemento;
        private NoFila proximo;

        public NoFila(){

            proximo = null;
        }

        public NoFila(NoArvoreBinaria _elemento, NoFila _proximo){

            elemento = _elemento;
            proximo = _proximo;
        }

        public NoArvoreBinaria getElemento(){

            return elemento;
        }

        public void setElemento(NoArvoreBinaria _elemento){

            elemento = _elemento;
        }

        public NoFila getProximo(){

            return proximo;
        }

        public void setProximo(NoFila _proximo){

            proximo = _proximo;
        }
    }
}
