using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PDesp
{
    public partial class frmTipoDespesa : Form
    {
        private BindingSource bnTipoDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsTipoDespesa = new DataSet();


        public frmTipoDespesa()
        {
            InitializeComponent();
        }

        private void frmTipoDespesa_Load(object sender, EventArgs e)
        {

            try
            {

                TipoDespesa Cid = new TipoDespesa();
                dsTipoDespesa.Tables.Add(Cid.Listar());
                bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];
                dgvTipoDespesa.DataSource = bnTipoDespesa;
                bnvTipoDespesa.BindingSource = bnTipoDespesa;

                txtId.DataBindings.Add("TEXT", bnTipoDespesa, "id_tipodespesa");
                txtNomeTipoDespesa.DataBindings.Add("TEXT", bnTipoDespesa, "nome_tipodespesa");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            bnTipoDespesa.AddNew();
            txtNomeTipoDespesa.Enabled = true;
    
            txtNomeTipoDespesa.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true; ;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TipoDespesa RegCid = new TipoDespesa();

                RegCid.IdTipoDespesa = Convert.ToInt16(txtId.Text);
                RegCid.NomeTipoDespesa = txtNomeTipoDespesa.Text;
                

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Tipo de despesa excluído com sucesso!");
                    TipoDespesa R = new TipoDespesa();
                    dsTipoDespesa.Tables.Clear();
                    dsTipoDespesa.Tables.Add(R.Listar());
                    bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir tipo de despesa!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNomeTipoDespesa.Text == "" )
            {
                MessageBox.Show("Tipo de despesa inválido!");
            }
            else
            {
                TipoDespesa RegCid = new TipoDespesa();

                RegCid.IdTipoDespesa = Convert.ToInt16(txtId.Text);
                RegCid.NomeTipoDespesa = txtNomeTipoDespesa.Text;
                

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa adicionado com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNomeTipoDespesa.Enabled = false;
                        
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegCid.Listar());
                        bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Tipo de despesa!");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa alterado com sucesso!");

                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(RegCid.Listar());
                        txtId.Enabled = false;
                        txtNomeTipoDespesa.Enabled = false;
                        
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar tipo de despesa!");
                    }

                }
            }

        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            txtNomeTipoDespesa.Enabled = true;
           
            txtNomeTipoDespesa.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            bnTipoDespesa.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeTipoDespesa.Enabled = false;
            
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
