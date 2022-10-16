using WindowsForms.view;

namespace WindowsForms
{
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
        private bool allowVisible = true;
        private bool allowClose;

        public frmPrincipal()
        {
            InitializeComponent();
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber);
            var childForm = new frmControlandoLista();
            childForm.MdiParent = this;
            childForm.Show();
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
            toolStripStatusLabel.Text = string.Format("Existe {0} telas abertas", childFormNumber+1);
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
    }
}
