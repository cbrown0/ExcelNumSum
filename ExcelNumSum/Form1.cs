namespace ExcelNumSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                // Do something with the selected file path, for example, display it in a textbox
                richTextBox1.Text = selectedFilePath;
            }
        }
    }
}
