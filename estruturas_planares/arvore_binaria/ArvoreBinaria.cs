/*

Estruturas de Dados - Árvore Binária (Classe Árvore Binária)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

using System;

namespace arvoreBinaria{

    class ArvoreBinaria{

        private NoArvoreBinaria raiz;

        public ArvoreBinaria(){

            raiz = null;
        }

        public bool eVazia(){

            return raiz == null;
        }

        public int inserir(int valor){

            if(eVazia()){

                raiz = new NoArvoreBinaria(valor);
                return 0;
            }
            
            return inserir(raiz, valor);
        }

        public int inserir(NoArvoreBinaria noAtual, int valor){

            if(valor < noAtual.getValor()){

                if(noAtual.getEsquerda() != null)

                    return inserir(noAtual.getEsquerda(), valor);
        
                noAtual.setEsquerda(new NoArvoreBinaria(valor));
            }

            else if(valor > noAtual.getValor()){

                if(noAtual.getDireita() != null)

                    return inserir(noAtual.getDireita(), valor);
                
                noAtual.setDireita(new NoArvoreBinaria(valor));
            }

            else

                return 1;
            
            return 0;
        }

        public int remover(int valor){

            if(raiz == null)

                return 2;
            
            return remover(raiz, null, valor);
        }

        public int remover(NoArvoreBinaria noAtual, NoArvoreBinaria noAnterior, int valor){

            if(valor > noAtual.getValor()){

                if(noAtual.getDireita() != null)

                    return remover(noAtual.getDireita(), noAtual, valor);
            }

            else if(valor < noAtual.getValor()){

                if(noAtual.getEsquerda() != null)

                    return remover(noAtual.getEsquerda(), noAtual, valor);
            }

            else{

                if(noAtual == raiz)

                    raiz = removerNo(noAtual);
                    
                else{

                    if(noAtual == noAnterior.getDireita())

                        noAnterior.setDireita(removerNo(noAtual));
                        
                    else

                        noAnterior.setEsquerda(removerNo(noAtual));
                }

                return 0;
            }

            return 1;
        }

        public NoArvoreBinaria removerNo(NoArvoreBinaria noAtual){

            if(noAtual.getEsquerda() == null)

                return noAtual.getDireita();
            
            else if(noAtual.getDireita() == null)

                return noAtual.getEsquerda();
            
            NoArvoreBinaria no1 = noAtual;
            NoArvoreBinaria no2 = noAtual.getDireita();

            while(no2.getEsquerda() != null){

                no1 = no2;
                no2 = no2.getEsquerda();
            }

            if(no1 != noAtual){

                no1.setEsquerda(no2.getDireita());
                no2.setDireita(noAtual.getDireita());
            }

            no2.setEsquerda(noAtual.getEsquerda());

            return no2;
        }

        public int quantidadeFolhas(){

            if(raiz == null)

                return 0;
            
            return quantidadeFolhas(raiz);
        }

        public int quantidadeFolhas(NoArvoreBinaria noAtual){

            if(noAtual == null)

                return 0;

            if(noAtual.getEsquerda() == null && noAtual.getDireita() == null)
            
                return 1;
            
            int quantidade_esquerda = quantidadeFolhas(noAtual.getEsquerda());
            int quantidade_direita = quantidadeFolhas(noAtual.getDireita());

            return quantidade_esquerda + quantidade_direita;
        }

        public void imprimirOrdemCrescente(){

            if(raiz == null)

                Console.WriteLine("\nÁrvore binária vazia.");
            
            else

                imprimirOrdemCrescente(raiz);
        }

        public void imprimirOrdemCrescente(NoArvoreBinaria noAtual){

            if(noAtual.getEsquerda() != null)

                imprimirOrdemCrescente(noAtual.getEsquerda());
            
            Console.Write(noAtual.getValor() + " ");

            if(noAtual.getDireita() != null)

                imprimirOrdemCrescente(noAtual.getDireita()); 
        }

        public void imprimirNosDoisFilhos(){

            if(raiz == null)

                Console.WriteLine("\nÁrvore binária vazia.");
            
            else

                imprimirNosDoisFilhos(raiz);
        }

        public void imprimirNosDoisFilhos(NoArvoreBinaria noAtual){

            if(noAtual.getEsquerda() != null)

                imprimirNosDoisFilhos(noAtual.getEsquerda());

            if(noAtual.getDireita() != null && noAtual.getEsquerda() != null)
            
                Console.Write(noAtual.getValor() + " ");

            if(noAtual.getDireita() != null)

                imprimirNosDoisFilhos(noAtual.getDireita()); 
        }
    }
}
