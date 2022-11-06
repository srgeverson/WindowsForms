using AppClassLibraryDomain.model;
using AppClassLibraryDomain.service;

namespace WindowsForms.view
{
    public partial class frmControlandoLista : Form
    {
        private UsuarioService usuarioService;
        private IList<Usuario> usuarios = new List<Usuario>();
        public frmControlandoLista()
        {
            InitializeComponent();
            if (usuarioService == null)
                usuarioService = new UsuarioService();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            usuarios = usuarioService.ListarTodos();
            dgvLista.DataSource = usuarios;
        }

        private void btnRemoveObjeto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                    throw new Exception("Informe o id");
                var usuario = usuarios.Where(u => u.Id == int.Parse(txtId.Text)).FirstOrDefault();
                if (usuario == null)
                    throw new Exception("usuário não encontrado com id informado");
                usuarios.Remove(usuario);
                //dgvLista.Rows.Clear();
                dgvLista.DataSource = null;
                dgvLista.DataSource = usuarios;
                MessageBox.Show("Usuário removido com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                      String.Format(ex.Message),
                      "Atenção",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                      );
            }
        }

        private void dgvLista_MouseClick(object sender, MouseEventArgs e)
        {
            //dgvLista.RowSe
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite apenas número
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void btnRemoveIndice_Click(object sender, EventArgs e)
        {
            try
            {
                var teste = new Usuario();
             var teste1=   teste.GetHashCode();
                var usuario = usuarios.ToList().FindIndex(u => u.Id == int.Parse(txtId.Text));
                if (usuario < 0)
                    throw new Exception("usuário não encontrado com id informado");
                usuarios.RemoveAt(usuario);
                dgvLista.DataSource = null;
                dgvLista.DataSource = usuarios;
                MessageBox.Show("Usuário removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                      String.Format(ex.Message),
                      "Atenção",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                      );
            }
        }
    }
}
