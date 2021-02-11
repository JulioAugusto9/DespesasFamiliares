using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDesp
{
    public partial class frmDespesa : Form
    {
        private BindingSource bnDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsDespesa = new DataSet();
        private DataSet dsTipoDespesa = new DataSet();
        private DataSet dsMembro = new DataSet();

        public frmDespesa()
        {
            InitializeComponent();
        }

        private void frmTipoDespesa_Load(object sender, EventArgs e)
        {

            try
            {
                Despesa Desp = new Despesa();
                dsDespesa.Tables.Add(Desp.Listar());
                bnDespesa.DataSource = dsDespesa.Tables["DESPESA"];
                dgvDespesa.DataSource = bnDespesa;
                bnvDespesa.BindingSource = bnDespesa;

                txtId.DataBindings.Add("TEXT", bnDespesa, "id_despesa");
                txtDataDespesa.DataBindings.Add("TEXT", bnDespesa, "data_despesa");
                txtValor.DataBindings.Add("TEXT", bnDespesa, "valor_despesa");
                txtObs.DataBindings.Add("TEXT", bnDespesa, "obs_despesa");

                TipoDespesa TD = new TipoDespesa();
                dsTipoDespesa.Tables.Add(TD.Listar());

                Membro Mem = new Membro();
                dsMembro.Tables.Add(Mem.Listar());

                cbxTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];
                cbxMembro.DataSource = dsMembro.Tables["MEMBRO"];

                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO

                cbxTipoDespesa.DisplayMember = "nome_tipodespesa";
                cbxMembro.DisplayMember = "nome_membro";

                //CAMPO QUE É A CHAVE DA TABELA CIDADE E QUE LIGA COM A TABELA DE Despesa

                cbxTipoDespesa.ValueMember = "id_tipodespesa";
                cbxMembro.ValueMember = "id_membro";


                //No momento de linkar os componentes com o Binding Source linkar também o combox da cidade

                cbxTipoDespesa.DataBindings.Add("SelectedValue", bnDespesa, "tipodespesa_id_tipodespesa"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
                cbxMembro.DataBindings.Add("SelectedValue", bnDespesa, "membro_id_membro");
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

            bnDespesa.AddNew();
            txtDataDespesa.Enabled = true;
            cbxTipoDespesa.Enabled = true;
            cbxTipoDespesa.SelectedIndex = 0;

            cbxMembro.Enabled = true;
            cbxMembro.SelectedIndex = 0;
            txtValor.Enabled = true;
            txtObs.Enabled = true;

            txtDataDespesa.Focus();
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
                Despesa RegDesp = new Despesa();

                RegDesp.IdDespesa = Convert.ToInt16(txtId.Text);
                RegDesp.DataDespesa = Convert.ToDateTime( txtDataDespesa.Text);
                RegDesp.TipoDespesaId = Convert.ToInt32(cbxTipoDespesa.SelectedValue);
                RegDesp.MembroId = Convert.ToInt32(cbxMembro.SelectedValue);
                RegDesp.ValorDespesa = Convert.ToDouble(txtValor.Text);
                RegDesp.ObsDespesa = txtObs.Text;

                if (RegDesp.Excluir() > 0)
                {
                    MessageBox.Show("Despesa excluída com sucesso!");
                    Despesa R = new Despesa();
                    dsDespesa.Tables.Clear();
                    dsDespesa.Tables.Add(R.Listar());
                    bnDespesa.DataSource = dsDespesa.Tables["DESPESA"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Despesa!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtDataDespesa.Text == "" || txtValor.Text == "" || txtObs.Text == "")
            {
                MessageBox.Show("Campos inválidos!");
            }
            else
            {
                Despesa RegDesp = new Despesa();

                RegDesp.IdDespesa = Convert.ToInt16(txtId.Text);
                RegDesp.DataDespesa = Convert.ToDateTime( txtDataDespesa.Text);
                RegDesp.TipoDespesaId = Convert.ToInt32(cbxTipoDespesa.SelectedValue);
                RegDesp.MembroId = Convert.ToInt32(cbxMembro.SelectedValue);
                RegDesp.ValorDespesa = Convert.ToDouble(txtValor.Text);
                RegDesp.ObsDespesa = txtObs.Text;

                if (bInclusao)
                {
                    if (RegDesp.Salvar() > 0)
                    {
                        MessageBox.Show("Despesa adicionado com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtDataDespesa.Enabled = false;
                        cbxTipoDespesa.Enabled = false;

                        cbxMembro.Enabled = false;
                        txtValor.Enabled = false;
                        txtObs.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDesp.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["DESPESA"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Despesa!");
                    }
                }
                else
                {
                    if (RegDesp.Alterar() > 0)
                    {
                        MessageBox.Show("Despesa alterado com sucesso!");

                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(RegDesp.Listar());
                        txtId.Enabled = false;
                        txtDataDespesa.Enabled = false;
                        cbxTipoDespesa.Enabled = false;

                        cbxMembro.Enabled = false;
                        txtValor.Enabled = false;
                        txtObs.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Despesa!");
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

            txtDataDespesa.Enabled = true;
            cbxTipoDespesa.Enabled = true;

            cbxMembro.Enabled = true;
            txtValor.Enabled = true;
            txtObs.Enabled = true;

            txtDataDespesa.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            bnDespesa.CancelEdit();

            btnSalvar.Enabled = false;
            txtDataDespesa.Enabled = false;
            cbxTipoDespesa.Enabled = false;

            cbxMembro.Enabled = false;
            txtValor.Enabled = false;
            txtObs.Enabled = false;

            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDespesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
