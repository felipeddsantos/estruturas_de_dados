/*

Estruturas de Dados - Palíndromo (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.IO;
using pilhaTemplate;

namespace palindromo{

    class Program{

        static void Main(string[] args){

            String inicial, final = "";
            Pilha<char> pilha = new Pilha<char>();
            
            Console.Write("Digite o texto a ser analisado: ");
            inicial = Console.ReadLine().Replace(" ", "");
            
            for(int i = 0; i < inicial.Length; i++)

                pilha.push(inicial[i]);
            
            while(!pilha.eVazia())

                final += pilha.pop();
            
            inicial = inicial.ToUpper();
            final = final.ToUpper();
                    
            if(String.Compare(inicial, final) == 0)
            
                Console.WriteLine("\nÉ palíndromo.");
            
            else

                Console.WriteLine("\nNão é palíndromo.");
        }
    }
}
