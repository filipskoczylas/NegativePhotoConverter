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
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnStart.Enabled = true;
                fileToConvert = openFileDialog.FileName;
                pbInput.Image = new Bitmap(fileToConvert);
                pbOutput.Image = null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(fileToConvert);
            int[] rgbArray = dllMenager.PrepareData(bitmap);
            if (rbAssembly.Checked)
            {
                dllMenager.PrepareAssembler(rgbArray, (int)nupThreads.Value);
                StartTimer();
                dllMenager.Run(rgbArray, (int)nupThreads.Value);
                StopTimer();
            }
            else
            {
                dllMenager.PrepareCsharp(rgbArray, (int)nupThreads.Value);
                StartTimer();
                dllMenager.Run(rgbArray, (int)nupThreads.Value);
                StopTimer();
            }
            Bitmap outputBitmap = dllMenager.ConvertToImage(rgbArray);
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
            if(lbTime.Text.Split("\n").Length > 4)
            {
                string[] times = lbTime.Text.Split("\n");
                lbTime.Text = times[0] + "\n" + times[1] + "\n" + times[2] + "\n" + times[3];
            }

            if (lbTime.Text == "0")
            {
                lbTime.Text = ticks.ToString();
            }
            else
            {
                lbTime.Text = ticks.ToString() + "\n" + lbTime.Text;
            }
        }

        #endregion

        #region Utility

        #endregion
    }
}