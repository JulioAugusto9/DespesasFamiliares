﻿namespace PDesp
{
    partial class frmMembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembro));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Dados = new System.Windows.Forms.TabPage();
            this.dgvMembro = new System.Windows.Forms.DataGridView();
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.txtPapelMembro = new System.Windows.Forms.TextBox();
            this.lblPapel = new System.Windows.Forms.Label();
            this.txtNomeMembro = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMembro = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bnvMembro = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.TabControl1.SuspendLayout();
            this.Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembro)).BeginInit();
            this.Detalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvMembro)).BeginInit();
            this.bnvMembro.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Dados);
            this.TabControl1.Controls.Add(this.Detalhes);
            this.TabControl1.Location = new System.Drawing.Point(-1, 51);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(356, 226);
            this.TabControl1.TabIndex = 6;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.dgvMembro);
            this.Dados.Location = new System.Drawing.Point(4, 22);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(348, 200);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // dgvMembro
            // 
            this.dgvMembro.AllowUserToAddRows = false;
            this.dgvMembro.AllowUserToDeleteRows = false;
            this.dgvMembro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembro.Location = new System.Drawing.Point(0, 3);
            this.dgvMembro.MaximumSize = new System.Drawing.Size(346, 182);
            this.dgvMembro.MinimumSize = new System.Drawing.Size(346, 182);
            this.dgvMembro.Name = "dgvMembro";
            this.dgvMembro.ReadOnly = true;
            this.dgvMembro.Size = new System.Drawing.Size(346, 182);
            this.dgvMembro.TabIndex = 0;
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.txtPapelMembro);
            this.Detalhes.Controls.Add(this.lblPapel);
            this.Detalhes.Controls.Add(this.txtNomeMembro);
            this.Detalhes.Controls.Add(this.txtId);
            this.Detalhes.Controls.Add(this.lblMembro);
            this.Detalhes.Controls.Add(this.lblId);
            this.Detalhes.Location = new System.Drawing.Point(4, 22);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhes.Size = new System.Drawing.Size(348, 200);
            this.Detalhes.TabIndex = 1;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            // 
            // txtPapelMembro
            // 
            this.txtPapelMembro.Enabled = false;
            this.txtPapelMembro.Location = new System.Drawing.Point(131, 112);
            this.txtPapelMembro.MaxLength = 10;
            this.txtPapelMembro.Name = "txtPapelMembro";
            this.txtPapelMembro.Size = new System.Drawing.Size(121, 20);
            this.txtPapelMembro.TabIndex = 4;
            // 
            // lblPapel
            // 
            this.lblPapel.AutoSize = true;
            this.lblPapel.Location = new System.Drawing.Point(25, 115);
            this.lblPapel.Name = "lblPapel";
            this.lblPapel.Size = new System.Drawing.Size(34, 13);
            this.lblPapel.TabIndex = 3;
            this.lblPapel.Text = "Papel";
            // 
            // txtNomeMembro
            // 
            this.txtNomeMembro.Enabled = false;
            this.txtNomeMembro.Location = new System.Drawing.Point(131, 75);
            this.txtNomeMembro.MaxLength = 20;
            this.txtNomeMembro.Name = "txtNomeMembro";
            this.txtNomeMembro.Size = new System.Drawing.Size(121, 20);
            this.txtNomeMembro.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(131, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblMembro
            // 
            this.lblMembro.AutoSize = true;
            this.lblMembro.Location = new System.Drawing.Point(25, 77);
            this.lblMembro.Name = "lblMembro";
            this.lblMembro.Size = new System.Drawing.Size(35, 13);
            this.lblMembro.TabIndex = 1;
            this.lblMembro.Text = "Nome";
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
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveNextItem.Text = "Próximo registro";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
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
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.BindingNavigatorMoveFirstItem.Text = "Primeiro registro";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.BindingNavigatorCountItem.Text = "de {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bnvMembro
            // 
            this.bnvMembro.AddNewItem = null;
            this.bnvMembro.CountItem = this.BindingNavigatorCountItem;
            this.bnvMembro.CountItemFormat = "de {0}";
            this.bnvMembro.DeleteItem = null;
            this.bnvMembro.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnvMembro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnvMembro.Location = new System.Drawing.Point(0, 0);
            this.bnvMembro.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.bnvMembro.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.bnvMembro.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.bnvMembro.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.bnvMembro.Name = "bnvMembro";
            this.bnvMembro.PositionItem = this.BindingNavigatorPositionItem;
            this.bnvMembro.Size = new System.Drawing.Size(481, 31);
            this.bnvMembro.TabIndex = 7;
            this.bnvMembro.Text = "bnvMembro";
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
            // frmMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 286);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.bnvMembro);
            this.Name = "frmMembro";
            this.Text = "frmMembro";
            this.Load += new System.EventHandler(this.frmMembro_Load);
            this.TabControl1.ResumeLayout(false);
            this.Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembro)).EndInit();
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvMembro)).EndInit();
            this.bnvMembro.ResumeLayout(false);
            this.bnvMembro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage Dados;
        internal System.Windows.Forms.DataGridView dgvMembro;
        internal System.Windows.Forms.TabPage Detalhes;
        private System.Windows.Forms.TextBox txtPapelMembro;
        private System.Windows.Forms.Label lblPapel;
        internal System.Windows.Forms.TextBox txtNomeMembro;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblMembro;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.ToolStripButton btnSair;
        internal System.Windows.Forms.ToolStripButton btnAlterar;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripButton btnExcluir;
        internal System.Windows.Forms.ToolStripButton btnNovoRegistro;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.BindingNavigator bnvMembro;
        internal System.Windows.Forms.ToolStripButton btnCancelar;
    }
}