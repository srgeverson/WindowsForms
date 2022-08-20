using AppClassLibraryDomain.DAO;
using System.Configuration;

namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (string.IsNullOrEmpty(ConexaoDAO.URLCONEXAO))
                ConexaoDAO.URLCONEXAO = ConfigurationManager.AppSettings["connectionString"];

            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal());
        }
    }
}