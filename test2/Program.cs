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
        public void HowManyCats()
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
            blackCat.HowManyCats();

            Cat yellowCat = new Cat();
            yellowCat.HowManyCats();
            
            Cat whiteCat = new Cat();
            whiteCat.HowManyCats();

            whiteCat.instance = 10;

            blackCat.HowManyCats();

            yellowCat.HowManyCats();

            whiteCat.HowManyCats();

            Console.ReadKey();
        }
    }
}
