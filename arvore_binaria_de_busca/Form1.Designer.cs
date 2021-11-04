/*

Estruturas de Dados - Árvore Binária de Busca (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

namespace arvoreBinariaDeBusca{

    partial class Interface{

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){

            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent(){
           
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.tb_adicionar = new System.Windows.Forms.TextBox();
            this.tb_remover = new System.Windows.Forms.TextBox();
            this.pb_desenho = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tb_imprimir = new System.Windows.Forms.TextBox();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_largura = new System.Windows.Forms.Button();
            this.bt_profundidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(12, 399);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(86, 39);
            this.bt_adicionar.TabIndex = 0;
            this.bt_adicionar.Text = "Adicionar Elemento";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(307, 399);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(86, 39);
            this.bt_remover.TabIndex = 1;
            this.bt_remover.Text = "Remover Elemento";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // tb_adicionar
            // 
            this.tb_adicionar.Location = new System.Drawing.Point(104, 408);
            this.tb_adicionar.Name = "tb_adicionar";
            this.tb_adicionar.Size = new System.Drawing.Size(58, 23);
            this.tb_adicionar.TabIndex = 2;
            this.tb_adicionar.TextChanged += new System.EventHandler(this.tb_adicionar_TextChanged);
            // 
            // tb_remover
            // 
            this.tb_remover.Location = new System.Drawing.Point(399, 408);
            this.tb_remover.Name = "tb_remover";
            this.tb_remover.Size = new System.Drawing.Size(58, 23);
            this.tb_remover.TabIndex = 3;
            this.tb_remover.TextChanged += new System.EventHandler(this.tb_remover_TextChanged_1);
            // 
            // pb_desenho
            // 
            this.pb_desenho.Location = new System.Drawing.Point(3, 3);
            this.pb_desenho.Name = "pb_desenho";
            this.pb_desenho.Size = new System.Drawing.Size(2000, 1500);
            this.pb_desenho.TabIndex = 0;
            this.pb_desenho.TabStop = false;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.pb_desenho);
            this.panel.Location = new System.Drawing.Point(0, -3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 331);
            this.panel.TabIndex = 4;
            // 
            // tb_imprimir
            // 
            this.tb_imprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_imprimir.Location = new System.Drawing.Point(104, 352);
            this.tb_imprimir.Name = "tb_imprimir";
            this.tb_imprimir.ReadOnly = true;
            this.tb_imprimir.Size = new System.Drawing.Size(353, 23);
            this.tb_imprimir.TabIndex = 5;
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Location = new System.Drawing.Point(12, 343);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(86, 39);
            this.bt_imprimir.TabIndex = 6;
            this.bt_imprimir.Text = "Imprimir Ordenados";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // bt_largura
            // 
            this.bt_largura.Location = new System.Drawing.Point(592, 399);
            this.bt_largura.Name = "bt_largura";
            this.bt_largura.Size = new System.Drawing.Size(154, 39);
            this.bt_largura.TabIndex = 7;
            this.bt_largura.Text = "Busca em Largura";
            this.bt_largura.UseVisualStyleBackColor = true;
            this.bt_largura.Click += new System.EventHandler(this.bt_largura_Click_1);
            // 
            // bt_profundidade
            // 
            this.bt_profundidade.Location = new System.Drawing.Point(592, 343);
            this.bt_profundidade.Name = "bt_profundidade";
            this.bt_profundidade.Size = new System.Drawing.Size(154, 39);
            this.bt_profundidade.TabIndex = 8;
            this.bt_profundidade.Text = "Busca em Profundidade";
            this.bt_profundidade.UseVisualStyleBackColor = true;
            this.bt_profundidade.Click += new System.EventHandler(this.bt_profundidade_Click_1);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_profundidade);
            this.Controls.Add(this.bt_largura);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.tb_imprimir);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tb_remover);
            this.Controls.Add(this.tb_adicionar);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Name = "Interface";
            this.Text = "Árvore Binária de Busca";
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.TextBox tb_adicionar;
        private System.Windows.Forms.TextBox tb_remover;
        private System.Windows.Forms.PictureBox pb_desenho;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tb_imprimir;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button bt_largura;
        private System.Windows.Forms.Button bt_profundidade;
    }
}
