using AppClassLibraryDomain.model;
using AppClassLibraryDomain.service;

namespace WindowsForms
{
    public partial class frmCRUDSQL : Form
    {
        private UsuarioService usuarioService;
        public frmCRUDSQL()
        {
            InitializeComponent();
            if (usuarioService == null)
                usuarioService = new UsuarioService();
        }

        private bool criticas()
        {
            try
            {
                if (usuarioService.BuscarPorEmail(txtEmail.Text) != null)
                    throw new Exception("Já existe usuário cadastrado com o e-maul informado!");

                if (!string.IsNullOrEmpty(txtSenha.Text))
                {
                    if (!txtSenha.Text.Equals(txtSenhaConfirma.Text))
                        throw new Exception("Senhas não são iguais!");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    String.Format("Dado inválido: {0}", ex.Message),
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (criticas())
                try
                {
                    var usuario = new Usuario()
                    {
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Ativo = ckbAtivo.Checked,
                        Senha = txtSenha.Text
                    };
                    usuarioService.Adicionar(usuario);
                    PreencheDadosUsuario(usuario);
                    MessageBox.Show(
                       String.Format("Usuário cadastrado com sucesso!"),
                       "Informativo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                   );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        String.Format("Erro ao cadastrar usuário: {0}", ex.Message),
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    var usuario = usuarioService.BuscarPorId(int.Parse(txtId.Text));

                    if (usuario == null)
                        throw new Exception("Não há usuário con o código informado!");
                    else
                        PreencheDadosUsuario(usuario);
                }
                else
                    dgvUsuarios.DataSource = usuarioService.ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Erro ao consultar usuário(s): {0}", ex.Message));
            }
        }

        private void PreencheDadosUsuario(Usuario usuario)
        {
            txtId.Text = usuario.Id.ToString();
            txtId.Enabled = false;
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            if (usuario.Ativo != null)
                ckbAtivo.Checked = (bool)usuario.Ativo;
            //txtSenha.Text = usuario.Senha;
            //txtSenhaConfirma.Text = usuario.Senha;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = String.Empty;
            txtId.Enabled = true;
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            ckbAtivo.Checked = false;
            txtSenha.Text = String.Empty;
            txtSenhaConfirma.Text = String.Empty;
            dgvUsuarios.DataSource = null;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (criticas())
                try
                {
                    usuarioService
                        .Alterar(new Usuario()
                        {
                            Id= Int32.Parse(txtId.Text),
                            Nome = txtNome.Text,
                            Email = txtEmail.Text,
                            Ativo = ckbAtivo.Checked,
                            Senha = txtSenha.Text
                        });
                    MessageBox.Show(
                       String.Format("Usuário atualizado com sucesso!"),
                       "Informativo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                   );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        String.Format("Erro ao atualizar usuário: {0}", ex.Message),
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite apenas número
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    var usuario = usuarioService.BuscarPorId(Int64.Parse(txtId.Text));
                    if (usuario == null)
                        throw new Exception("Não há usuário con o código informado!");
                    else
                    {
                        usuarioService.Excluir(usuario.Id);
                        MessageBox.Show(
                            String.Format("Usuário removido com sucesso!"),
                            "Informativo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    }
                }
                else
                    throw new Exception("Informe o código do usuário!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                       String.Format("Não foi possível apagar o usuário: {0}", ex.Message),
                       "Atenção",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                       );
            }
        }
    }
}
