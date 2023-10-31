using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace NegativePhotoConverter
{
    internal class DllMenager
    {
        [DllImport("..\\..\\..\\..\\x64\\Debug\\NegativeConverterAssembly.dll", EntryPoint = "MyProc")]
        private static extern unsafe int MyProc(int[] rgbArray, int startPosition, int endPosition);
        Thread[] threads;
        object[] dllResult;
        public DllMenager() 
        {
            threads = new Thread[64];
        }
        private int height;
        private int width;
        public void PrepareAssembler(int[] rgbArray, int threadsNumber)
        {
            int computedSize = rgbArray.Length / threadsNumber;
            try
            {
                for (int i = 0; i < threadsNumber - 1; i++)
                {
                    int index = i;
                    threads[index] = new Thread(
                        () =>
                        {
                            MyProc(rgbArray, (index * computedSize), ((index + 1) * computedSize));
                        }
                        );
                }
                threads[threadsNumber - 1] = new Thread(
                    () =>
                    {
                        MyProc(rgbArray, ((threadsNumber - 1) * computedSize), rgbArray.Length);
                    }
                    );
            }
            catch (Exception)
            {

            }
        }

        public void PrepareCsharp(int[] rgbArray, int threadsNumber)
        {
            string path = @"..\..\..\..\NegativeConverter\bin\Debug\net6.0\NegativeConverter.dll";
            var assembly = Assembly.LoadFrom(path);
            var type = assembly.GetType("NegativeConverter.NegativeConverter");
            var activator = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("ConvertToNegative");
            dllResult = new object[threadsNumber];
            int computedSize = rgbArray.Length / threadsNumber;
            for (int i = 0; i < threadsNumber - 1; i++)
            {
                int index = i;
                threads[index] = new Thread(
                    ()=>
                    {
                        method.Invoke(activator, new object[] {rgbArray, (index * computedSize), ((index + 1) * computedSize) });
                    }
                    );
            }

            threads[threadsNumber - 1] = new Thread(
                    () =>
                    {
                        method.Invoke(activator, new object[] { rgbArray, ((threadsNumber - 1) * computedSize), rgbArray.Length});
                    }
                    );
        }
        public int[] Run(int[] rgbArray, int threadsNumber)
        {
            for (int i = 0; i < threadsNumber; i++)
            {
                int index = i;
                threads[index].Start();
            }
            for (int i = 0; i < threadsNumber; i++)
            {
                int index = i;
                threads[index].Join();
            }
            return rgbArray;
        }
        public int[] PrepareData(Bitmap bitmap)
        {
            width = bitmap.Width;
            height = bitmap.Height;
            //r << 16, g << 8, b
            uint size = (uint)(height * width);
            int[] rgbArray = new int[size];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    rgbArray[y * width + x] = pixel.R << 16 | pixel.G << 8 | pixel.B;
                }
            }
            return rgbArray;
        }
        public Bitmap ConvertToImage(int[] rgbArray)
        {
            Bitmap result = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (uint i = 0; i < height*width; i++)
            {
                result.SetPixel((int)i % width, (int)i / width, Color.FromArgb((byte)255, (byte)(rgbArray[i] >> 16), (byte)(rgbArray[i] >> 8), (byte)(rgbArray[i])));
            }
            return result;
        }
    }
}
