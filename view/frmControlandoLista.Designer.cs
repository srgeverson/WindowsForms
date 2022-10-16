namespace WindowsForms.view
{
    partial class frmControlandoLista
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnRemoveObjeto = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnRemoveIndice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(12, 12);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvLista.Location = new System.Drawing.Point(2, 240);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowTemplate.Height = 25;
            this.dgvLista.Size = new System.Drawing.Size(786, 198);
            this.dgvLista.TabIndex = 1;
            // 
            // btnRemoveObjeto
            // 
            this.btnRemoveObjeto.Location = new System.Drawing.Point(113, 52);
            this.btnRemoveObjeto.Name = "btnRemoveObjeto";
            this.btnRemoveObjeto.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveObjeto.TabIndex = 2;
            this.btnRemoveObjeto.Text = "Remove Por Objeto";
            this.btnRemoveObjeto.UseVisualStyleBackColor = true;
            this.btnRemoveObjeto.Click += new System.EventHandler(this.btnRemoveObjeto_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 3;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // btnRemoveIndice
            // 
            this.btnRemoveIndice.Location = new System.Drawing.Point(288, 52);
            this.btnRemoveIndice.Name = "btnRemoveIndice";
            this.btnRemoveIndice.Size = new System.Drawing.Size(131, 23);
            this.btnRemoveIndice.TabIndex = 4;
            this.btnRemoveIndice.Text = "Remove Por Indice";
            this.btnRemoveIndice.UseVisualStyleBackColor = true;
            this.btnRemoveIndice.Click += new System.EventHandler(this.btnRemoveIndice_Click);
            // 
            // frmControlandoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveIndice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnRemoveObjeto);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnConsulta);
            this.Name = "frmControlandoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controlando Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConsulta;
        private DataGridView dgvLista;
        private Button btnRemoveObjeto;
        private TextBox txtId;
        private Button btnRemoveIndice;
    }
}