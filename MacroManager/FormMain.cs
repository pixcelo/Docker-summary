namespace MacroManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog(this) == DialogResult.OK)
                {
                    textBoxBrowse.Text = fd.SelectedPath;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExcute_Click(object sender, EventArgs e)
        {

        }
    }
}