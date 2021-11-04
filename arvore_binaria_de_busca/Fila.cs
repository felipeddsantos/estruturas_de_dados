/*

Estruturas de Dados - Árvore Binária de Busca (Classe Fila)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

namespace arvoreBinariaDeBusca{

    class Fila{

        private NoFila inicio;
        private NoFila fim;

        public Fila(){

            inicio = null;
            fim = null;
        }

        public bool eVazia(){

            return inicio == null;
        }

        public NoArvoreBinaria lerInicio(){

            if(eVazia())

                return default;

            return inicio.getElemento();
        }

        public void inserirElemento(NoArvoreBinaria elemento){

            NoFila novo = new NoFila(elemento, null);

            if(eVazia()){

                inicio = novo;
                fim = novo;
            }

            else{

                fim.setProximo(novo);
                fim = novo;
            }
        }

        public NoArvoreBinaria removerElemento(){

            if(eVazia())

                return default;

            NoArvoreBinaria temp = inicio.getElemento();
            inicio = inicio.getProximo();

            return temp;
        }
    }
}
