/*

Estruturas de Dados - Árvore Binária (Classe Árvore Binária)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;

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

        public int buscar(int valor){

            if(eVazia())

                return 2;
            
            return buscar(raiz, valor);
        }

        public int buscar(NoArvoreBinaria noAtual, int valor){

            if(valor < noAtual.getValor()){

                if(noAtual.getEsquerda() != null)

                    return buscar(noAtual.getEsquerda(), valor);
            }

            else if(valor > noAtual.getValor()){

                if(noAtual.getDireita() != null)

                    return buscar(noAtual.getDireita(), valor);
            }

            else

                return 0;
            
            return 1;
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

        public int altura(){

            if(raiz == null)

                return 0;
            
            return altura(raiz);
        }

        public int altura(NoArvoreBinaria noAtual){

            if(noAtual == null)

                return -1;
            
            int altura_esquerda = altura(noAtual.getEsquerda());
            int altura_direita = altura(noAtual.getDireita());

            if(altura_esquerda > altura_direita)

                return altura_esquerda + 1;
                
            else

                return altura_direita + 1;
        }

        public int quantidadeNos(){

            if(raiz == null)

                return 0;
            
            return quantidadeNos(raiz);
        }

        public int quantidadeNos(NoArvoreBinaria noAtual){

            if(noAtual == null)

                return 0;
            
            int quantidade_esquerda = quantidadeNos(noAtual.getEsquerda());
            int quantidade_direita = quantidadeNos(noAtual.getDireita());

            return quantidade_esquerda + quantidade_direita + 1;
        }

        public void imprimirPreOrdem(){

            if(raiz == null)

                Console.WriteLine("\nÁrvore vazia.\n");
            
            else

                imprimirPreOrdem(raiz);
        }

        public void imprimirPreOrdem(NoArvoreBinaria noAtual){
            
            Console.Write(noAtual.getValor() + " ");

            if(noAtual.getEsquerda() != null)

                imprimirPreOrdem(noAtual.getEsquerda());

            if(noAtual.getDireita() != null)

                imprimirPreOrdem(noAtual.getDireita()); 
        }

        public void imprimirEmOrdem(){

            if(raiz == null)

                Console.WriteLine("\nÁrvore vazia.\n");
            
            else

                imprimirEmOrdem(raiz);
        }

        public void imprimirEmOrdem(NoArvoreBinaria noAtual){

            if(noAtual.getEsquerda() != null)

                imprimirEmOrdem(noAtual.getEsquerda());
            
            Console.Write(noAtual.getValor() + " ");

            if(noAtual.getDireita() != null)

                imprimirEmOrdem(noAtual.getDireita()); 
        }

        public void imprimirPosOrdem(){

            if(raiz == null)

                Console.WriteLine("\nÁrvore vazia.\n");
            
            else

                imprimirPosOrdem(raiz);
        }

        public void imprimirPosOrdem(NoArvoreBinaria noAtual){

            if(noAtual.getEsquerda() != null)

                imprimirPosOrdem(noAtual.getEsquerda());
            
            if(noAtual.getDireita() != null)

                imprimirPosOrdem(noAtual.getDireita()); 

            Console.Write(noAtual.getValor() + " ");
        }
    }
}
