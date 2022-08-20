namespace WindowsForms
{
    public partial class frmTHread : Form
    {
        private int count = 0;
        private int max = 5000;
        public frmTHread()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < max; i++)
            {
                count++;
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(1);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            MessageBox.Show("Finalizou!");
            label1.Text = "W1 terminado!";
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            label1.Text = "W1 trabalhando...";
            label2.Text = count.ToString();
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
    }
}