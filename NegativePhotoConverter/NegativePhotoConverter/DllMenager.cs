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
        MethodInfo method;
        object activatior;
        public DllMenager() 
        {
            try
            {
                Assembly assembly = Assembly.LoadFile("TODO");
                Type type = assembly.GetType("TODO");
                activatior = Activator.CreateInstance(type, 1);
                method = type.GetMethod("TODO NAME");
            }
            catch
            {
                
            }
        }
    }
}
