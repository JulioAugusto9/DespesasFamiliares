namespace PDesp
{
    partial class frmTipoDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDespesa));
            this.dgvTipoDespesa = new System.Windows.Forms.DataGridView();
            this.Dados = new System.Windows.Forms.TabPage();
            this.txtNomeTipoDespesa = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.bnvTipoDespesa = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDespesa)).BeginInit();
            this.Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvTipoDespesa)).BeginInit();
            this.bnvTipoDespesa.SuspendLayout();
            this.Detalhes.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTipoDespesa
            // 
            this.dgvTipoDespesa.AllowUserToAddRows = false;
            this.dgvTipoDespesa.AllowUserToDeleteRows = false;
            this.dgvTipoDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDespesa.Location = new System.Drawing.Point(0, 3);
            this.dgvTipoDespesa.MaximumSize = new System.Drawing.Size(346, 182);
            this.dgvTipoDespesa.MinimumSize = new System.Drawing.Size(346, 182);
            this.dgvTipoDespesa.Name = "dgvTipoDespesa";
            this.dgvTipoDespesa.ReadOnly = true;
            this.dgvTipoDespesa.Size = new System.Drawing.Size(346, 182);
            this.dgvTipoDespesa.TabIndex = 0;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.dgvTipoDespesa);
            this.Dados.Location = new System.Drawing.Point(4, 22);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(348, 200);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // txtNomeTipoDespesa
            // 
            this.txtNomeTipoDespesa.Enabled = false;
            this.txtNomeTipoDespesa.Location = new System.Drawing.Point(131, 75);
            this.txtNomeTipoDespesa.MaxLength = 20;
            this.txtNomeTipoDespesa.Name = "txtNomeTipoDespesa";
            this.txtNomeTipoDespesa.Size = new System.Drawing.Size(121, 20);
            this.txtNomeTipoDespesa.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(131, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(25, 77);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblTipoDespesa.TabIndex = 1;
            this.lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(28, 28);
            this.btnCancelar.Text = "Cancelar Alteração";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bnvTipoDespesa
            // 
            this.bnvTipoDespesa.AddNewItem = null;
            this.bnvTipoDespesa.CountItem = this.BindingNavigatorCountItem;
            this.bnvTipoDespesa.CountItemFormat = "de {0}";
            this.bnvTipoDespesa.DeleteItem = null;
            this.bnvTipoDespesa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnvTipoDespesa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.btnNovoRegistro,
            this.btnExcluir,
            this.btnSalvar,
            this.btnAlterar,
            this.btnCancelar,
            this.btnSair});
            this.bnvTipoDespesa.Location = new System.Drawing.Point(0, 0);
            this.bnvTipoDespesa.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.bnvTipoDespesa.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.bnvTipoDespesa.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.bnvTipoDespesa.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.bnvTipoDespesa.Name = "bnvTipoDespesa";
            this.bnvTipoDespesa.PositionItem = this.BindingNavigatorPositionItem;
            this.bnvTipoDespesa.Size = new System.Drawing.Size(471, 31);
            this.bnvTipoDespesa.TabIndex = 5;
            this.bnvTipoDespesa.Text = "bnvTipoDespesa";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.BindingNavigatorCountItem.Text = "de {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveFirstItem.Text = "Primeiro registro";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMovePreviousItem.Text = "Registro anterior";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveNextItem.Text = "Próximo registro";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveLastItem.Text = "Último Registro";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoRegistro.Image")));
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.RightToLeftAutoMirrorImage = true;
            this.btnNovoRegistro.Size = new System.Drawing.Size(28, 28);
            this.btnNovoRegistro.Text = "Adicionar Novo Registro";
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(28, 28);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(28, 28);
            this.btnSalvar.Text = "Salvar Registros";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(28, 28);
            this.btnAlterar.Text = "Alterar Registro";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 28);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.txtNomeTipoDespesa);
            this.Detalhes.Controls.Add(this.txtId);
            this.Detalhes.Controls.Add(this.lblTipoDespesa);
            this.Detalhes.Controls.Add(this.lblId);
            this.Detalhes.Location = new System.Drawing.Point(4, 22);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhes.Size = new System.Drawing.Size(348, 200);
            this.Detalhes.TabIndex = 1;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Dados);
            this.TabControl1.Controls.Add(this.Detalhes);
            this.TabControl1.Location = new System.Drawing.Point(-1, 34);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(356, 226);
            this.TabControl1.TabIndex = 4;
            // 
            // frmTipoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 243);
            this.Controls.Add(this.bnvTipoDespesa);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmTipoDespesa";
            this.Text = ",";
            this.Load += new System.EventHandler(this.frmTipoDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDespesa)).EndInit();
            this.Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnvTipoDespesa)).EndInit();
            this.bnvTipoDespesa.ResumeLayout(false);
            this.bnvTipoDespesa.PerformLayout();
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvTipoDespesa;
        internal System.Windows.Forms.TabPage Dados;
        internal System.Windows.Forms.TextBox txtNomeTipoDespesa;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblTipoDespesa;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.BindingNavigator bnvTipoDespesa;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton btnNovoRegistro;
        internal System.Windows.Forms.ToolStripButton btnExcluir;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripButton btnAlterar;
        internal System.Windows.Forms.ToolStripButton btnSair;
        internal System.Windows.Forms.TabPage Detalhes;
        internal System.Windows.Forms.TabControl TabControl1;

    }
}