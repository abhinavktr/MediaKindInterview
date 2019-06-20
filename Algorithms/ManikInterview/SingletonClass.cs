using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public interface sampleInterface
    {
        int Sum(int a, int b);
    }

    public static class SingletonClass //: sampleInterface
    {
        private static int count = 0;
        //public int normalCount = 0; // this gives compilation error

        static SingletonClass()
        {

            Console.WriteLine(++count);
        }

        //public int Sum(int a, int b)
        //{
        //    throw new NotImplementedException();
        //}

        //public int SampleMethod() //This gives compilation error, a static class can't have instance methods
        //{
        //    return 10;
        //}
    }

    public class NormalClass
    {
        private static int count = 0;
        private int normalCount = 0;

        static NormalClass()
        {
            //normalCount++; // An object reference is required for this non static class.
            Console.WriteLine(++count);
        }

        public NormalClass()
        {
            normalCount++;
        }
    }
}
