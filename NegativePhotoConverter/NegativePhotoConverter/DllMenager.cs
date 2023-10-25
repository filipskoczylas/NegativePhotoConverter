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
        [DllImport("C:\\Users\\Filip\\Desktop\\NegativePhotoConverter\\NegativePhotoConverter\\x64\\Debug\\NegativeConverterAssembly.dll", EntryPoint = "MyProc")]
        private static extern unsafe int MyProc(int* rgbArray, int startPosition, int endPosition);
        public DllMenager() { }
        private int height;
        private int width;
        public int[] RunAssembler(int[] rgbArray, int threads)
        {
            int? a;
            try
            {
                unsafe
                {
                    fixed (int* pRgbArray = rgbArray)
                    {
                        a = MyProc(pRgbArray, 0, (rgbArray.Length)/2);
                    }
                }
            }
            catch (Exception)
            {

            }
            return rgbArray;
        }
        public int[] RunCsharp(int[] rgbArray, int threads)
        {
            var path = @"C:\Users\Filip\Desktop\NegativePhotoConverter\NegativePhotoConverter\NegativeConverter\bin\Debug\net6.0\NegativeConverter.dll";
            var assembly = Assembly.LoadFrom(path);
            var type = assembly.GetType("NegativeConverter.NegativeConverter");
            var activator = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("ConvertToNegative");
            object result = method.Invoke(activator, new object[] { rgbArray });

            int[] toReturn = (int[])result;

            return toReturn;
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
