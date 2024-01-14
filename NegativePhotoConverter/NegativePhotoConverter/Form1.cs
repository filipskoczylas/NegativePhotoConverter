/**
 * @Project     Negative photo converter
 * @Author      Filip Skoczylas
 * @Version     1.0
 * @Year        2023/2024
 * @Semestre    5
 */
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Management;

namespace NegativePhotoConverter
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        DllMenager dllMenager;
        string fileToConvert;
        uint processorFrequency; // in MHZ
        public Form1()
        {
            InitializeComponent();
            dllMenager= new DllMenager();
            DetermineProcessorFrequency();
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
            long microSeconds = ticks / processorFrequency;
            if(lbTime.Text.Split("\n").Length > 4)
            {
                string[] times = lbTime.Text.Split("\n");
                lbTime.Text = times[0] + "\n" + times[1] + "\n" + times[2] + "\n" + times[3];
            }

            if (lbTime.Text == "0")
            {
                lbTime.Text = microSeconds.ToString();
            }
            else
            {
                lbTime.Text = microSeconds.ToString() + "\n" + lbTime.Text;
            }
        }

        #endregion

        #region Utility
        void DetermineProcessorFrequency()
        {
            using ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
            processorFrequency = (uint)(Mo["MaxClockSpeed"]); // in MHZ
        }
        #endregion
    }
}