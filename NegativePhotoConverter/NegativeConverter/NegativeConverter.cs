/**
 * @Project     Negative photo converter
 * @Author      Filip Skoczylas
 * @Version     1.0
 * @Year        2023/2024
 * @Semestre    5
 */
using System.Drawing;
using System.Drawing.Text;

namespace NegativeConverter
{
    public class NegativeConverter
    {
        public NegativeConverter() { }
        public void ConvertToNegative(int[] rgbArray, int start, int end)
        {
            //Check if null
            if(rgbArray == null) return;

            for(int i = start; i < end; i++)
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
            //return rgbArray;
         }
    }
}