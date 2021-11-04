/*

Estruturas de Dados - Árvore Binária de Busca (Classe Árvore Binária)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

using System;
using System.Collections.Generic;

namespace arvoreBinariaDeBusca{

    class ArvoreBinaria{

        public NoArvoreBinaria raiz;

        public ArvoreBinaria(){

            raiz = null;
        }

        public bool eVazia(){

            return raiz == null;
        }

        public int inserir(int valor){

            int nivel = 0;

            if(eVazia()){

                raiz = new NoArvoreBinaria(valor);
                raiz.setX(950);
                raiz.setY(0);

                return 0;
            }

            return inserir(raiz, valor, nivel);
        }

        public int inserir(NoArvoreBinaria noAtual, int valor, int nivel){

            if(valor < noAtual.getValor()){

                if(noAtual.getEsquerda() != null){

                    nivel++;

                    return inserir(noAtual.getEsquerda(), valor, nivel);
                }

                NoArvoreBinaria novoNo = new NoArvoreBinaria(valor);

                noAtual.setEsquerda(novoNo);
                novoNo.setX(noAtual.getX() - 125 + 20 * (nivel % 3));
                novoNo.setY(noAtual.getY() + 90);
                novoNo.setNivel(nivel);
            }

            else if(valor > noAtual.getValor()){

                if(noAtual.getDireita() != null){

                    nivel++;

                    return inserir(noAtual.getDireita(), valor, nivel);
                }

                NoArvoreBinaria novoNo = new NoArvoreBinaria(valor);

                noAtual.setDireita(novoNo);
                novoNo.setX(noAtual.getX() + 125 - 25 * (nivel % 3));
                novoNo.setY(noAtual.getY() + 90);
                novoNo.setNivel(nivel);
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

        public List<NoArvoreBinaria> obterListaNos(){

            List<NoArvoreBinaria> listaNos = new List<NoArvoreBinaria>();

            if(raiz == null)

                return listaNos;

            else

                return obterListaNos(raiz, listaNos);
        }

        public List<NoArvoreBinaria> obterListaNos(NoArvoreBinaria noAtual, List<NoArvoreBinaria> listaNos){

            listaNos.Add(noAtual);

            if(noAtual.getEsquerda() != null)

                obterListaNos(noAtual.getEsquerda(), listaNos);

            if(noAtual.getDireita() != null)

                obterListaNos(noAtual.getDireita(), listaNos);

            return listaNos;
        }

        public String obterListaOrdenada(){

            if(raiz == null)

                return "";

            else

                return obterListaOrdenada(raiz);
        }

        public String obterListaOrdenada(NoArvoreBinaria noAtual){

            String esquerda = "", direita = "", meio;

            if(noAtual.getEsquerda() != null)

                esquerda = obterListaOrdenada(noAtual.getEsquerda());

            meio = noAtual.getValor().ToString() + " ";

            if(noAtual.getDireita() != null)

                direita = obterListaOrdenada(noAtual.getDireita());

            return esquerda + meio + direita;
        }

        public List<NoArvoreBinaria> buscaLargura(){

            List<NoArvoreBinaria> largura = new List<NoArvoreBinaria>();

            if(raiz == null)

                return largura;

            else

                return buscaLargura(raiz, largura);
        }

        public List<NoArvoreBinaria> buscaLargura(NoArvoreBinaria raiz, List<NoArvoreBinaria> largura){

            Fila fila = new Fila();
            NoArvoreBinaria noAtual = raiz;

            fila.inserirElemento(noAtual);

            while(!fila.eVazia()){

                noAtual = fila.removerElemento();
                largura.Add(noAtual);

                if(noAtual.getEsquerda() != null)

                    fila.inserirElemento(noAtual.getEsquerda());

                if(noAtual.getDireita() != null)

                    fila.inserirElemento(noAtual.getDireita());
            }
            
            return largura;
        }

        public List<NoArvoreBinaria> buscaProfundidade(){

            List<NoArvoreBinaria> profundidade = new List<NoArvoreBinaria>();

            if(raiz == null)

                return profundidade;

            else

                return buscaProfundidade(raiz, profundidade);
        }

        public List<NoArvoreBinaria> buscaProfundidade(NoArvoreBinaria raiz, List<NoArvoreBinaria> profundidade){

            Pilha pilha = new Pilha();
            NoArvoreBinaria noAtual = raiz;

            pilha.push(noAtual);

            while(!pilha.eVazia()){

                noAtual = pilha.pop();
                profundidade.Add(noAtual);

                if(noAtual.getDireita() != null)

                    pilha.push(noAtual.getDireita());

                if(noAtual.getEsquerda() != null)

                    pilha.push(noAtual.getEsquerda());
            }

            return profundidade;
        }
    }
}
