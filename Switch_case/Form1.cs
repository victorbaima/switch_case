using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            /*o conteúdo da combobox (cboSemana) será analisado e de acordo com a
             * opção escolhida, acontecerá uma determinada mensagem. Caso o 
             * usuário escolha Domingo, será uma msg, caso escolha Segunda, outra
             * e assim por diante. A cada case, uma nova opção.
             * O break serve para sair de determinado comando, neste exemplo o (case)
             * em execução*/
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu Domingo que é o 1º da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Você escolheu Segunda que é o 2º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu Terça que é o 3º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu Quarta que é o 4º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu Quinta que é o 5º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu Sexta que é o 6º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sábado":
                    MessageBox.Show("Você escolheu Sábado que é o 7º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            //Declara o elemento novo tipo form e chama em seguida através do método Show.
            novo.Show();
            //fecha o formulário atual
            this.Visible = false;
        }
    }
}
