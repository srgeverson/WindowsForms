namespace WindowsForms.view
{
    partial class FormSistema
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grbFeriado = new System.Windows.Forms.GroupBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.btnListarFeriados = new System.Windows.Forms.Button();
            this.grbCriaTabela = new System.Windows.Forms.GroupBox();
            this.txtNomeTabela = new System.Windows.Forms.TextBox();
            this.btnCriarTabela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.grbFeriado.SuspendLayout();
            this.grbCriaTabela.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 618);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 123;
            this.dgvDados.RowTemplate.Height = 57;
            this.dgvDados.Size = new System.Drawing.Size(2244, 596);
            this.dgvDados.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(2000, 536);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(225, 69);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // grbFeriado
            // 
            this.grbFeriado.Controls.Add(this.cbAno);
            this.grbFeriado.Controls.Add(this.btnListarFeriados);
            this.grbFeriado.Location = new System.Drawing.Point(1900, 12);
            this.grbFeriado.Name = "grbFeriado";
            this.grbFeriado.Size = new System.Drawing.Size(325, 227);
            this.grbFeriado.TabIndex = 7;
            this.grbFeriado.TabStop = false;
            this.grbFeriado.Text = "Feriados";
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(35, 65);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(253, 56);
            this.cbAno.TabIndex = 6;
            // 
            // btnListarFeriados
            // 
            this.btnListarFeriados.Location = new System.Drawing.Point(35, 137);
            this.btnListarFeriados.Name = "btnListarFeriados";
            this.btnListarFeriados.Size = new System.Drawing.Size(256, 69);
            this.btnListarFeriados.TabIndex = 5;
            this.btnListarFeriados.Text = "Listar Feriados";
            this.btnListarFeriados.UseVisualStyleBackColor = true;
            // 
            // grbCriaTabela
            // 
            this.grbCriaTabela.Controls.Add(this.txtNomeTabela);
            this.grbCriaTabela.Controls.Add(this.btnCriarTabela);
            this.grbCriaTabela.Location = new System.Drawing.Point(1951, 245);
            this.grbCriaTabela.Name = "grbCriaTabela";
            this.grbCriaTabela.Size = new System.Drawing.Size(265, 215);
            this.grbCriaTabela.TabIndex = 8;
            this.grbCriaTabela.TabStop = false;
            this.grbCriaTabela.Text = "Criar Tabela";
            // 
            // txtNomeTabela
            // 
            this.txtNomeTabela.Location = new System.Drawing.Point(29, 63);
            this.txtNomeTabela.Name = "txtNomeTabela";
            this.txtNomeTabela.Size = new System.Drawing.Size(207, 55);
            this.txtNomeTabela.TabIndex = 7;
            // 
            // btnCriarTabela
            // 
            this.btnCriarTabela.Location = new System.Drawing.Point(29, 130);
            this.btnCriarTabela.Name = "btnCriarTabela";
            this.btnCriarTabela.Size = new System.Drawing.Size(213, 69);
            this.btnCriarTabela.TabIndex = 6;
            this.btnCriarTabela.Text = "Criar Tabela";
            this.btnCriarTabela.UseVisualStyleBackColor = true;
            this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
            // 
            // FormSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2268, 1226);
            this.Controls.Add(this.grbCriaTabela);
            this.Controls.Add(this.grbFeriado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvDados);
            this.Name = "FormSistema";
            this.Text = "Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.grbFeriado.ResumeLayout(false);
            this.grbCriaTabela.ResumeLayout(false);
            this.grbCriaTabela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDados;
        private Button btnLimpar;
        private GroupBox grbFeriado;
        private ComboBox cbAno;
        private Button btnListarFeriados;
        private GroupBox grbCriaTabela;
        private TextBox txtNomeTabela;
        private Button btnCriarTabela;
    }
}