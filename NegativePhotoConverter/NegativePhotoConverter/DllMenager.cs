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

namespace NegativePhotoConverter
{
    internal class DllMenager
    {
        public DllMenager() { }
        public object Run(Bitmap bitmap, int threads)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            //r << 16, g << 8, b
            uint size = (uint)(height * width);
            int[] rgbArray = new int[size];
            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    rgbArray[y * width + x] = pixel.R << 16 | pixel.G << 8 | pixel.B;//(255 - (pixel.R << 16)) | (255 - (pixel.G << 8)) | (255 - pixel.B);
                }
            }
            Bitmap returned = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            for (uint i = 0; i < size; i++)
            {
                returned.SetPixel((int)i % width,(int) i / height, Color.FromArgb((byte)(rgbArray[i] >> 16), (byte)(rgbArray[i] >> 8), (byte)(rgbArray[i])));
            }
            //var path = @"C:\Users\Filip\Desktop\NegativePhotoConverter\NegativePhotoConverter\NegativeConverter\bin\Debug\net6.0\NegativeConverter.dll";
            var assembly = Assembly.LoadFrom("ClassLibrary1.dll");
            var type = assembly.GetType("ClassLibrary1.Class1");
            var activator = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("Hello");
;           object result = method.Invoke(activator, new object[] { 4});
            return returned;
        }
    }
}
