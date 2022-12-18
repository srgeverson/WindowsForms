using AppClassLibraryDomain.service;
using Spring.Context.Support;
using Spring.Context;
using AppClassLibraryDomain.exception;

namespace WindowsForms.view
{
    public partial class FormSistema : Form
    {
        private static readonly IApplicationContext CONTEXT = ContextRegistry.GetContext();
        private ISistemaService _sistemaService;
        private bool feriadoConsultado, configuracoes;
        public FormSistema()
        {
            try
            {
                InitializeComponent();
                if (_sistemaService == null)
                    _sistemaService = (ISistemaService)CONTEXT.GetObject("SistemaNHibernateService");
                CarregarDados();
            }
            catch (SistemaException sex)
            {
                MessageBox.Show(
                      String.Format("{0}", sex.Message),
                      "Atênção",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                      );
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
        private void CarregarDados()
        {
            cbAno.Items.Clear();
            for (var i = 0; i >= -10; i--)
            {
                var ano = DateTime.Now.AddYears(i).Year;
                //cbAno.Items.Insert(ano, String.Format("Ano - {0}", ano));
                cbAno.Items.Add(ano);
            }
            cbAno.SelectedIndex = -1;
        }
        private void btnListarFeriados_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAno.SelectedIndex == -1)
                    throw new SistemaException("Selecione o ano para cosultar os feriados");
                dgvDados.DataSource = _sistemaService.BuscarFeriadoPorAno(Int32.Parse(cbAno.SelectedItem.ToString()));
            }
            catch (SistemaException sex)
            {
                MessageBox.Show(
                      String.Format("{0}", sex.Message),
                      "Atênção",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                      );
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
            finally
            {
                feriadoConsultado = true;
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNomeTabela.Text))
                    throw new SistemaException("Informe o nome da tabela");
                _sistemaService.CriarTabelaComNomeInformado(txtNomeTabela.Text);
                MessageBox.Show(
                      String.Format("Tabela criada com sucesso!"),
                      "Operação realizada",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                      );
            }
            catch (SistemaException sex)
            {
                MessageBox.Show(
                      String.Format("{0}", sex.Message),
                      "Atênção",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                      );
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
            finally
            {
                feriadoConsultado = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            feriadoConsultado = false;
            configuracoes = false;
        }
    }
}
