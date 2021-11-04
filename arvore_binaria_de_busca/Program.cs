/*

Estruturas de Dados - Árvore Binária de Busca (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

using System;
using System.Windows.Forms;

namespace ArvoreBinariaDeBusca{

    static class Program{

        public static ArvoreBinaria arvore = new ArvoreBinaria();

        [STAThread]
        static void Main(){

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
