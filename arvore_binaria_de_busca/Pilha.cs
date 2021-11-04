/*

Estruturas de Dados - Árvore Binária de Busca (Classe Pilha)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

namespace arvoreBinariaDeBusca{

    class Pilha{

        private NoPilha topo;

        public Pilha(){

            topo = null;
        }

        public bool eVazia(){

            return topo == null;
        }

        public NoArvoreBinaria lerTopo(){

            if(eVazia())

                return default;

            return topo.getElemento();
        }

        public void push(NoArvoreBinaria elemento){

            if(eVazia())

                topo = new NoPilha(elemento, null);

            else{

                NoPilha proximo = new NoPilha(elemento, topo);
                topo = proximo;
            }
        }

        public NoArvoreBinaria pop(){

            if(eVazia())

                return default;

            NoArvoreBinaria temp = topo.getElemento();
            topo = topo.getProximo();
            
            return temp;
        }
    }
}
