﻿using AppClassLibraryDomain.service;
using Spring.Context;
using Spring.Context.Support;
using WindowsForms.view;

namespace WindowsForms
{
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
        private bool allowVisible = true;
        private bool allowClose;
        private static readonly IApplicationContext CONTEXT = ContextRegistry.GetContext();
        private ISistemaService _sistemaService;

        public frmPrincipal()
        {
            try
            {

                InitializeComponent();
                toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber);
                if (_sistemaService == null)
                    _sistemaService = (ISistemaService)CONTEXT.GetObject("SistemaNHibernateService");
                var feriados = _sistemaService.BuscarFeriadoPorAno(DateTime.Now.Year);
                tsslSistema.Text = _sistemaService.Sistema(AppDomain.CurrentDomain.FriendlyName.Split('.')[0]);
                //var childForm = new frmControlandoLista();
                //childForm.MdiParent = this;
                //childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                      String.Format("Houve erro ao inicializar sistema. Detalhes: {0}", ex.Message),
                      "Erro",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                      );
                throw;
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber + 1);
            var childForm = new frmTHread();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultaNHibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber + 1);
            var childForm = new frmCRUDNHibernate();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tsmiCRUDEntityFrameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber + 1);
            var childForm = new frmCRUDEntityFramework();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tsmiCRUDSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber + 1);
            var childForm = new frmCRUDSQL();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }

        private void tsmiControlandoLista_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber + 1);
            var childForm = new frmControlandoLista();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tsmiConfiguracoes_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber + 1);
            var childForm = new FormSistema();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
