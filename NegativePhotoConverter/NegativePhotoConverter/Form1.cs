namespace NegativePhotoConverter
{
    public partial class Form1 : Form
    {
        DllMenager dllMenager;
        string[] filesToConvert;
        public Form1()
        {
            InitializeComponent();
            dllMenager= new DllMenager();
            InitializeComboBox();
        }

        private void btnLoadImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect= true;
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Title = "Select images to convert";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|All files (*.*)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filesToConvert = openFileDialog.FileNames;
            }
            else
            {
                MessageBox.Show("Failed to open files");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //dllMenager.Run(rbAssembly.Checked);//Todo
        }
        #region Utility
        private void InitializeComboBox()
        {
            for (int i = 1; i < 65; i++)
            {
                cmbThreads.Items.Add(i.ToString());
            }
        }
        #endregion
    }
}