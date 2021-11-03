using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class Cat
    {
       public Cat()
        {
            instance++;
        }
        public void HowManyCat()
        {
            Console.WriteLine("{0} Cats",instance);
        }
        public int instance = 0;// cac doi tuong co instance rieng
        /*
         public static int instance // cac doi tuong dung chung instance 
         private access in class
         */
    }
    public class Tester
    {
        public static void Main()
        {
            Cat blackCat = new Cat();
            blackCat.HowManyCat();

            Cat yellowCat = new Cat();
            yellowCat.HowManyCat();
            
            Cat whiteCat = new Cat();
            whiteCat.HowManyCat();

            Console.ReadKey();
        }
    }
}
