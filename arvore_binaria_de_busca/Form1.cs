/*

Estruturas de Dados - Árvore Binária de Busca (Aplicação Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArvoreBinariaDeBusca{

    public partial class Interface : Form{
        
        Bitmap areaDesenho;

        public Interface(){

            InitializeComponent();

            areaDesenho = new Bitmap(pb_desenho.Width, pb_desenho.Height);
        }

        private void desenharArvore(){

            Graphics surface = Graphics.FromImage(areaDesenho);
            surface.Clear(pb_desenho.BackColor);

            Pen cor = new Pen(Color.Black, 2);
            Font fonte = new Font("Arial", 16);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;

            List<NoArvoreBinaria> listaNos = Program.arvore.obterListaNos();

            foreach(NoArvoreBinaria no in listaNos){

                int x = no.getX();
                int y = no.getY();

                surface.DrawEllipse(cor, x, y, 50, 50);

                Rectangle retangulo = new Rectangle(x, y, 50, 50);
                
                TextRenderer.DrawText(surface, no.getValor().ToString(), fonte, retangulo, Color.Blue, flags);

                if(no.getDireita() != null)

                    surface.DrawLine(cor, x + 25, y + 50, x + 150 - 25 * (no.getDireita().getNivel() % 3), y + 90);

                if(no.getEsquerda() != null)
                
                    surface.DrawLine(cor, x + 25, y + 50, x - 100 + 25 * (no.getEsquerda().getNivel() % 3), y + 90);
            }

            pb_desenho.Image = areaDesenho;
            panel.AutoScrollPosition = new Point(613, 0);
        }

        private void desenharBusca(List<NoArvoreBinaria> listaNos){

            Graphics surface = Graphics.FromImage(areaDesenho);

            Pen cor = new Pen(Color.Red, 2);

            foreach(NoArvoreBinaria no in listaNos){

                surface.DrawEllipse(cor, no.getX(), no.getY(), 50, 50);
                pb_desenho.Image = areaDesenho;
                delay(1000);
            }
        }

        public void delay(int tempo){

            var timer1 = new Timer();
            
            if(tempo == 0 || tempo < 0) 
                
                return;

            timer1.Interval = tempo;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>{

                timer1.Enabled = false;
                timer1.Stop();
            };

            while(timer1.Enabled)
            
                Application.DoEvents();
        }

        void bt_adicionar_Click(object sender, EventArgs e){

            if(tb_adicionar.Text == "")

                MessageBox.Show("Insira somente números inteiros.");

            else{

                int resultado = Program.arvore.inserir(int.Parse(tb_adicionar.Text));

                if(resultado == 0)

                    desenharArvore();

                else

                    MessageBox.Show("Elemento já exsitente na árvore.");
            }
        }

        private void tb_adicionar_TextChanged(object sender, EventArgs e){

            if(System.Text.RegularExpressions.Regex.IsMatch(tb_adicionar.Text, "[^0-9]")){

                MessageBox.Show("Insira somente números inteiros.");
                tb_adicionar.Text = tb_adicionar.Text.Remove(tb_adicionar.Text.Length - 1);
            }
        }

        void bt_remover_Click(object sender, EventArgs e){

            if(tb_remover.Text == "")

                MessageBox.Show("Insira somente números inteiros.");

            else{

                int resultado = Program.arvore.remover(int.Parse(tb_remover.Text));

                if(resultado == 0){

                    List<NoArvoreBinaria> listaNos = Program.arvore.obterListaNos();
                    ArvoreBinaria novaArvore = new ArvoreBinaria();

                    foreach(NoArvoreBinaria no in listaNos)

                        novaArvore.inserir(no.getValor());

                    Program.arvore = novaArvore;
                    desenharArvore();
                }

                else if(resultado == 1)

                    MessageBox.Show("Elemento inexistente na árvore.");

                else

                    MessageBox.Show("Árvore vazia.");
            }
        }

        private void tb_remover_TextChanged(object sender, EventArgs e){

            if(System.Text.RegularExpressions.Regex.IsMatch(tb_remover.Text, "[^0-9]")){

                MessageBox.Show("Insira somente números inteiros.");
                tb_remover.Text = tb_remover.Text.Remove(tb_remover.Text.Length - 1);
            }
        }

        private void bt_imprimir_Click(object sender, EventArgs e){

            tb_imprimir.Text = Program.arvore.obterListaOrdenada();
        }

        private void bt_profundidade_Click(object sender, EventArgs e){

            desenharArvore();
            List<NoArvoreBinaria> profundidade = Program.arvore.buscaProfundidade();
            desenharBusca(profundidade);
        }

        private void bt_largura_Click(object sender, EventArgs e){

            desenharArvore();
            List<NoArvoreBinaria> largura = Program.arvore.buscaLargura();
            desenharBusca(largura);
        }
    }
}
