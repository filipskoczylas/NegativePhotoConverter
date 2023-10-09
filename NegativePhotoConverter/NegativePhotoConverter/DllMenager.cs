using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NegativePhotoConverter
{
    internal class DllMenager
    {
        public DllMenager() { }
        public object Run(Bitmap bitmap, int threads)
        {
            string path = @"C:\Users\Filip\Desktop\NegativePhotoConverter\NegativePhotoConverter\NegativeConverter\bin\Debug\net6.0\NegativeConverter.dll";
            var assembly = Assembly.LoadFile(path);
            var type = assembly.GetType("NegativeConverter.NegativeConverter");
            var activator = Activator.CreateInstance(type);
            var method = type.GetMethod("ConvertToNegative");
            var result = method.Invoke(activator, new object[] { bitmap, threads });
            return result;
        }
    }
}
