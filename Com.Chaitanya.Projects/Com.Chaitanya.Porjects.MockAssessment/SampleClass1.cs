using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Chaitanya.Porjects.MockAssessment
{
    public  class SampleClass1
    {


        int c = 30;

        public static void getNumber()
        {
            int a = 10;
            Console.WriteLine("this is get number method");
            Console.WriteLine("a value is:" +a);
            a = 100;
            Console.WriteLine("a value now is" + a);
            a = 200;




        }
        public static void getRandom()
        {
            Console.WriteLine("this is get random method");
            int b = 300;
        }
    }
}
