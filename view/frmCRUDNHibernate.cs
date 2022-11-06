using AppClassLibraryDomain.model;
using AppClassLibraryDomain.service;
using Spring.Context;
using Spring.Context.Support;

namespace WindowsForms
{
    public partial class frmCRUDNHibernate : Form
    {
        private IUsuarioService _usuarioService;
        private static readonly IApplicationContext CONTEXT = ContextRegistry.GetContext();
        private readonly string PASTA_TEMP_APP = Path.Combine(Directory.GetCurrentDirectory(), "Temp");
        public frmCRUDNHibernate()
        {
            InitializeComponent();
            if (_usuarioService == null)
                _usuarioService = (IUsuarioService)CONTEXT.GetObject("UsuarioNHibernateService");

            if (!Directory.Exists(PASTA_TEMP_APP))
                Directory.CreateDirectory(PASTA_TEMP_APP);
        }

        private bool criticas()
        {
            try
            {
                if (_usuarioService.BuscarPorEmail(txtEmail.Text) != null)
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
                    _usuarioService.Adicionar(usuario);
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
                    var usuario = _usuarioService.BuscarPorId(Int64.Parse(txtId.Text));

                    if (usuario == null)
                        throw new Exception("Não há usuário con o código informado!");
                    else
                        PreencheDadosUsuario(usuario);
                }
                else
                    dgvUsuarios.DataSource = _usuarioService.ListarTodos();
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

            if (usuario.UsuarioFotoPerfil != null)
            {
                var bytes = usuario.UsuarioFotoPerfil.Arquivo;
                var nomeArquivo = Path.Combine(PASTA_TEMP_APP, usuario.UsuarioFotoPerfil.Nome);
                if (!File.Exists(nomeArquivo))
                    using (var fileStream = new FileStream(nomeArquivo, FileMode.CreateNew, FileAccess.Write))
                    {
                        fileStream.Write(bytes, 0, bytes.Length);
                        fileStream.Flush();
                    }
                pcbFotoPerfil.Image = Image.FromFile(nomeArquivo);
                btnAlterarFotoPerfil.Enabled = true;
                btnApagarFotoPerfil.Enabled = true;
            }
            else
                btnSalvarFotoPerfil.Enabled = true;
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
            btnAlterarFotoPerfil.Enabled = false;
            btnApagarFotoPerfil.Enabled = false;
            btnSalvarFotoPerfil.Enabled = false;
            pcbFotoPerfil.ImageLocation = String.Empty;
            ofdFotoPerfil.FileName = String.Empty;
            pcbFotoPerfil.Image = null;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (criticas())
                try
                {
                    var usuario = new Usuario()
                    {
                        Id = Int64.Parse(txtId.Text),
                        Nome = txtNome.Text,
                        Email = txtEmail.Text,
                        Ativo = ckbAtivo.Checked,
                        Senha = txtSenha.Text
                    };
                    _usuarioService.Alterar(usuario);
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
            if (e.KeyChar == 13)
                btnConsultar_Click(null, null);
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
                    var usuario = _usuarioService.BuscarPorId(Int64.Parse(txtId.Text));
                    if (usuario == null)
                        throw new Exception("Não há usuário con o código informado!");
                    else
                    {
                        if (usuario.UsuarioFotoPerfil != null)
                        {
                            pcbFotoPerfil.Image = null;
                            if (File.Exists(usuario.UsuarioFotoPerfil.Caminho))
                                File.Delete(usuario.UsuarioFotoPerfil.Caminho);
                            if (File.Exists(Path.Combine(PASTA_TEMP_APP, usuario.UsuarioFotoPerfil.Nome)))
                                File.Delete(Path.Combine(PASTA_TEMP_APP, usuario.UsuarioFotoPerfil.Nome));
                        }
                        _usuarioService.Excluir(usuario.Id);
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

        private void btnAlterarFotoPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    throw new Exception("Salve/Consulte o usuário antes!");
                }
                else
                {
                    var usuario = _usuarioService.BuscarPorId(Int64.Parse(txtId.Text));
                    var usuarioFoto = usuario.UsuarioFotoPerfil;
                    usuarioFoto.Nome = ofdFotoPerfil.FileName;
                    usuarioFoto.Caminho = ofdFotoPerfil.FileName;
                    _usuarioService.AtualizarFoto(usuarioFoto);
                    btnSalvarFotoPerfil.Enabled = false;
                    btnAlterarFotoPerfil.Enabled = !btnSalvarFotoPerfil.Enabled;
                    btnApagarFotoPerfil.Enabled = !btnSalvarFotoPerfil.Enabled;
                    MessageBox.Show(
                       "Foto alterada com sucesso!",
                       "Informação",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                       );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                       String.Format("Não foi possível alterar a foto do usuário: {0}", ex.Message),
                       "Atenção",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                       );
            }
        }

        private void btnSalvarFotoPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    throw new Exception("Salve/Consulte o usuário antes!");
                }
                else
                {
                    var usuario = _usuarioService.BuscarPorId(Int64.Parse(txtId.Text));
                    if (usuario == null)
                        throw new Exception("Não há usuário con o código informado!");

                    if (string.IsNullOrEmpty(ofdFotoPerfil.FileName))
                        throw new Exception("Selecione uma foto!");

                    var usuarioFoto = new UsuarioFotoPerfil();
                    usuarioFoto.Usuario = usuario;
                    usuarioFoto.Nome = ofdFotoPerfil.SafeFileName;
                    usuarioFoto.Caminho = ofdFotoPerfil.FileName;
                    usuarioFoto.MimeType = string.Format("image/{0}", ofdFotoPerfil.SafeFileName.Split(".")[1]);
                    FileInfo fileInfo = new FileInfo(ofdFotoPerfil.FileName);
                    byte[] bytes = null;
                    using (var fileStream = new FileStream(ofdFotoPerfil.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        bytes = new byte[Convert.ToInt32(fileInfo.Length)];
                        int iBytesRead = fileStream.Read(bytes, 0, Convert.ToInt32(fileInfo.Length));
                    }
                    usuarioFoto.Arquivo = bytes;
                    _usuarioService.CadastrarFoto(usuarioFoto);
                    btnSalvarFotoPerfil.Enabled = false;
                    btnAlterarFotoPerfil.Enabled = !btnSalvarFotoPerfil.Enabled;
                    btnApagarFotoPerfil.Enabled = !btnSalvarFotoPerfil.Enabled;
                    MessageBox.Show(
                       "Foto salva com sucesso!",
                       "Informação",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                       );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                       String.Format("Não foi possível salvar a foto do usuário: {0}", ex.Message),
                       "Atenção",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                       );
            }
        }

        private void pcbFotoPerfil_Click(object sender, EventArgs e)
        {
            ofdFotoPerfil.Title = "Pesquisando fotos";
            ofdFotoPerfil.DefaultExt = "png";
            ofdFotoPerfil.Filter = "Foto (*.png)|*.png|Todos Arquivos (*.*)|*.*";
            ofdFotoPerfil.CheckFileExists = true;
            ofdFotoPerfil.ShowDialog();
            if(File.Exists(ofdFotoPerfil.FileName))
                pcbFotoPerfil.Image = Image.FromFile(ofdFotoPerfil.FileName);
        }

        private void btnApagarFotoPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    throw new Exception("Salve/Consulte o usuário antes!");
                }
                else
                {
                    var usuario = _usuarioService.BuscarPorId(Int64.Parse(txtId.Text));
                    var usuarioFoto = usuario.UsuarioFotoPerfil;
                    pcbFotoPerfil.Image = null;
                    if (File.Exists(usuarioFoto.Caminho))
                        File.Delete(usuarioFoto.Caminho);
                    if (File.Exists(Path.Combine(PASTA_TEMP_APP, usuarioFoto.Nome)))
                        File.Delete(Path.Combine(PASTA_TEMP_APP, usuarioFoto.Nome));
                    _usuarioService.ApagarFotoUsuario(usuarioFoto);
                    pcbFotoPerfil.ImageLocation = String.Empty;
                    ofdFotoPerfil.FileName = String.Empty;
                    btnSalvarFotoPerfil.Enabled = true;
                    btnAlterarFotoPerfil.Enabled = !btnSalvarFotoPerfil.Enabled;
                    btnApagarFotoPerfil.Enabled = !btnSalvarFotoPerfil.Enabled;
                    MessageBox.Show(
                       "Foto apagada com sucesso!",
                       "Informação",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                       );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                       String.Format("Não foi possível alterar a foto do usuário: {0}", ex.Message),
                       "Atenção",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                       );
            }
        }
    }
}
