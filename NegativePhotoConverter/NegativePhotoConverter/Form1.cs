using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NegativePhotoConverter
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        DllMenager dllMenager;
        string[] filesToConvert;
        public Form1()
        {
            InitializeComponent();
            dllMenager= new DllMenager();
            RunTimerFirstTime();
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
            int a = 0;
            StartTimer();
            //dllMenager.Run(rbAssembly.Checked);//Todo
            for(int i = 0; i < 100000; i++)
            {
                a++;
            }
            StopTimer();
        }

        #region Timer
        //First run takes longer, first run is made when app starts to prevent misleading data. 
        private void RunTimerFirstTime()
        {
            StartTimer();
            StopTimer();
            lbTime.Text = "0";
        }
        public void StartTimer()
        {
            stopwatch = Stopwatch.StartNew();
        }

        public void StopTimer()
        {
            stopwatch.Stop();
            long ticks = stopwatch.ElapsedTicks;
            lbTime.Text = ticks.ToString();
        }
        #endregion

        #region Utility

        #endregion


    }
}