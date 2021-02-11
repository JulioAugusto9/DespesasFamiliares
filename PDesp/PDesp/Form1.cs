using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PDesp
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try{
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2;User ID=SeuIDaqui;Password=SuaSenhaAqui");
                conexao.Open();
            }
            catch (SqlException ex){
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex){
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void tipoDeDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDespesa frmTD = new frmTipoDespesa();
            frmTD.MdiParent = this;
            frmTD.WindowState = FormWindowState.Maximized;
            frmTD.Show();
        }

        private void membroFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembro frmMem = new frmMembro();
            frmMem.MdiParent = this;
            frmMem.WindowState = FormWindowState.Maximized;
            frmMem.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDespesa frmDesp = new frmDespesa();
            frmDesp.MdiParent = this;
            frmDesp.WindowState = FormWindowState.Maximized;
            frmDesp.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema para Controle de Despesas Familiar \nProjeto da Faculdade de Tecnologia de Sorocaba \nDesenvolvido para a disciplina de Linguagem de Programação 2, Professora Denilce Veloso \nCriado por Julio Almeida, Leonardo Hirosue e Maria Anita de Moura\nVersão 1.0.0");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
