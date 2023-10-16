using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NegativePhotoConverter
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        DllMenager dllMenager;
        string fileToConvert;
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
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Title = "Select images to convert";
            openFileDialog.RestoreDirectory = true;
            //openFileDialog.Filter = "Images (*.jpg;*.png,*.jpeg)|All files (*.*)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileToConvert = openFileDialog.FileName;
                pbInput.Image = new Bitmap(fileToConvert);
                pbOutput.Image = null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int a = 0;
            Bitmap bitmap = new Bitmap(fileToConvert);
            StartTimer();
            object result = dllMenager.Run(bitmap, (int)nupThreads.Value);
            StopTimer();
            Bitmap outputBitmap = (Bitmap)result;
            pbOutput.Image = outputBitmap;
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