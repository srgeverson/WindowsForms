﻿namespace WindowsForms
{
    partial class frmCRUDNHibernate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDNHibernate));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSenhaConfirma = new System.Windows.Forms.TextBox();
            this.lblSenhaConfirma = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.pcbNHibernate = new System.Windows.Forms.PictureBox();
            this.btnSalvarFotoPerfil = new System.Windows.Forms.Button();
            this.pcbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnAlterarFotoPerfil = new System.Windows.Forms.Button();
            this.btnApagarFotoPerfil = new System.Windows.Forms.Button();
            this.ofdFotoPerfil = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNHibernate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(129, 210);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 239);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(854, 250);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(16, 151);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 15);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(16, 169);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(147, 23);
            this.txtSenha.TabIndex = 4;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(259, 71);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(54, 19);
            this.ckbAtivo.TabIndex = 2;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSenhaConfirma
            // 
            this.txtSenhaConfirma.Location = new System.Drawing.Point(178, 169);
            this.txtSenhaConfirma.Name = "txtSenhaConfirma";
            this.txtSenhaConfirma.PasswordChar = '*';
            this.txtSenhaConfirma.Size = new System.Drawing.Size(135, 23);
            this.txtSenhaConfirma.TabIndex = 5;
            // 
            // lblSenhaConfirma
            // 
            this.lblSenhaConfirma.AutoSize = true;
            this.lblSenhaConfirma.Location = new System.Drawing.Point(178, 151);
            this.lblSenhaConfirma.Name = "lblSenhaConfirma";
            this.lblSenhaConfirma.Size = new System.Drawing.Size(93, 15);
            this.lblSenhaConfirma.TabIndex = 13;
            this.lblSenhaConfirma.Text = "confirmar senha";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 15);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Código";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(14, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(147, 23);
            this.txtId.TabIndex = 0;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(444, 210);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(238, 210);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(340, 210);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 18;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // pcbNHibernate
            // 
            this.pcbNHibernate.Image = ((System.Drawing.Image)(resources.GetObject("pcbNHibernate.Image")));
            this.pcbNHibernate.Location = new System.Drawing.Point(538, 9);
            this.pcbNHibernate.Name = "pcbNHibernate";
            this.pcbNHibernate.Size = new System.Drawing.Size(328, 146);
            this.pcbNHibernate.TabIndex = 19;
            this.pcbNHibernate.TabStop = false;
            // 
            // btnSalvarFotoPerfil
            // 
            this.btnSalvarFotoPerfil.Enabled = false;
            this.btnSalvarFotoPerfil.Location = new System.Drawing.Point(340, 114);
            this.btnSalvarFotoPerfil.Name = "btnSalvarFotoPerfil";
            this.btnSalvarFotoPerfil.Size = new System.Drawing.Size(51, 23);
            this.btnSalvarFotoPerfil.TabIndex = 20;
            this.btnSalvarFotoPerfil.Text = "Salvar";
            this.btnSalvarFotoPerfil.UseVisualStyleBackColor = true;
            this.btnSalvarFotoPerfil.Click += new System.EventHandler(this.btnSalvarFotoPerfil_Click);
            // 
            // pcbFotoPerfil
            // 
            this.pcbFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pcbFotoPerfil.Image")));
            this.pcbFotoPerfil.Location = new System.Drawing.Point(340, 12);
            this.pcbFotoPerfil.Name = "pcbFotoPerfil";
            this.pcbFotoPerfil.Size = new System.Drawing.Size(168, 96);
            this.pcbFotoPerfil.TabIndex = 21;
            this.pcbFotoPerfil.TabStop = false;
            this.pcbFotoPerfil.Click += new System.EventHandler(this.pcbFotoPerfil_Click);
            // 
            // btnAlterarFotoPerfil
            // 
            this.btnAlterarFotoPerfil.Enabled = false;
            this.btnAlterarFotoPerfil.Location = new System.Drawing.Point(397, 115);
            this.btnAlterarFotoPerfil.Name = "btnAlterarFotoPerfil";
            this.btnAlterarFotoPerfil.Size = new System.Drawing.Size(50, 23);
            this.btnAlterarFotoPerfil.TabIndex = 22;
            this.btnAlterarFotoPerfil.Text = "Alterar";
            this.btnAlterarFotoPerfil.UseVisualStyleBackColor = true;
            this.btnAlterarFotoPerfil.Click += new System.EventHandler(this.btnAlterarFotoPerfil_Click);
            // 
            // btnApagarFotoPerfil
            // 
            this.btnApagarFotoPerfil.Enabled = false;
            this.btnApagarFotoPerfil.Location = new System.Drawing.Point(453, 115);
            this.btnApagarFotoPerfil.Name = "btnApagarFotoPerfil";
            this.btnApagarFotoPerfil.Size = new System.Drawing.Size(55, 23);
            this.btnApagarFotoPerfil.TabIndex = 23;
            this.btnApagarFotoPerfil.Text = "Apagar";
            this.btnApagarFotoPerfil.UseVisualStyleBackColor = true;
            this.btnApagarFotoPerfil.Click += new System.EventHandler(this.btnApagarFotoPerfil_Click);
            // 
            // frmCRUDNHibernate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 501);
            this.Controls.Add(this.btnSalvarFotoPerfil);
            this.Controls.Add(this.btnApagarFotoPerfil);
            this.Controls.Add(this.btnAlterarFotoPerfil);
            this.Controls.Add(this.pcbFotoPerfil);
            this.Controls.Add(this.pcbNHibernate);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSenhaConfirma);
            this.Controls.Add(this.txtSenhaConfirma);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ckbAtivo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnConsultar);
            this.Name = "frmCRUDNHibernate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CRUD NHibernate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNHibernate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConsultar;
        private DataGridView dgvUsuarios;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private CheckBox ckbAtivo;
        private Button btnSalvar;
        private TextBox txtSenhaConfirma;
        private Label lblSenhaConfirma;
        private Label lblId;
        private TextBox txtId;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button btnApagar;
        private PictureBox pcbNHibernate;
        private Button btnSalvarFotoPerfil;
        private PictureBox pcbFotoPerfil;
        private Button btnAlterarFotoPerfil;
        private Button btnApagarFotoPerfil;
        private OpenFileDialog ofdFotoPerfil;
    }
}