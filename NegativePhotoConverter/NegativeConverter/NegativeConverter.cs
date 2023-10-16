using System.Drawing;
using System.Drawing.Text;

namespace NegativeConverter
{
    public class NegativeConverter
    {
        private readonly object Lock = new object();
        public NegativeConverter() { }
        public int[] ConvertToNegative(int[] rgbArray)
        {
            //Check if null
            if(rgbArray == null) return null;

            for(int i = 0; i < rgbArray.Length; i++)
            {
                byte r = (byte)(rgbArray[i] >> 16);
                byte g = (byte)(rgbArray[i] >> 8);
                byte b = (byte)(rgbArray[i]);

                //Negation

                byte negR = (byte)(255 - r);
                byte negG = (byte)(255 - g);
                byte negB = (byte)(255 - b);

                //Putting back into array
                int negRGB = (negR << 16) | negG << 8 | negB;
                rgbArray[i] = negRGB;
            }
            return rgbArray;
            /*
            try
            {
                int width = bitmap.Width;
                int height = bitmap.Height;
                int heightStep = height / threads;
                Thread[] thread = new Thread[threads];
                for(int i = 0; i < threads - 1; i++)
                {
                    thread[i] = new Thread(() => ConvertAsync(ref bitmap, width, i * heightStep, (i + 1) * heightStep));
                }
                thread[threads - 1] = new Thread(() => ConvertAsync(ref bitmap, width, (threads-1) * heightStep, height));

                for(int i = 0; i < threads; i++)
                {
                    thread[i].Start();
                }
            }
            catch { }
            return bitmap;*/
        }
        private void ConvertAsync(ref Bitmap bitmap, int width, int startHeight, int endHeight)
        {
            for(int x= 0; x<width; x++)
            {
                for(int y = startHeight; y < endHeight; y++)
                {
                    SetPixelAsync(ref bitmap, x, y);
                }
            }
        }
        private void SetPixelAsync(ref Bitmap bitmap, int x, int y)
        {
            Color pixel = Color.Black;
            lock (Lock)
            {
                pixel = bitmap.GetPixel(x, y);
            }
            int a = pixel.A;
            int r = 255 - pixel.R;
            int g = 255 - pixel.G;
            int b = 255 - pixel.B;
            lock (Lock)
            {
                bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));
            }
        }
    }
}