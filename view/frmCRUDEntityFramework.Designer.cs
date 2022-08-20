namespace WindowsForms
{
    partial class frmCRUDEntityFramework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDEntityFramework));
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
            this.pcbEntityFramework = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEntityFramework)).BeginInit();
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
            // pcbEntityFramework
            // 
            this.pcbEntityFramework.Image = ((System.Drawing.Image)(resources.GetObject("pcbEntityFramework.Image")));
            this.pcbEntityFramework.Location = new System.Drawing.Point(639, 9);
            this.pcbEntityFramework.Name = "pcbEntityFramework";
            this.pcbEntityFramework.Size = new System.Drawing.Size(227, 224);
            this.pcbEntityFramework.TabIndex = 19;
            this.pcbEntityFramework.TabStop = false;
            // 
            // frmCRUDEntityFramework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 501);
            this.Controls.Add(this.pcbEntityFramework);
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
            this.Name = "frmCRUDEntityFramework";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CRUD Entity Framework";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEntityFramework)).EndInit();
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
        private PictureBox pcbEntityFramework;
    }
}