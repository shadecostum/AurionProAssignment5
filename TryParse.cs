using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryParse();
            intParse();
            converToint();
        }

       

        private static void TryParse()
        {
            Console.WriteLine("---------TryParse--------- ");
            //convert string to integer
            //can handle null values
            //can check value integer or not  like valid number else return false
            string value = "123";
            string valueNotInt = "aa123b";

            int.TryParse(value, out int convertNumber);
            Console.WriteLine("converted Number :"+convertNumber);

            int.TryParse(valueNotInt, out int convertNotInt);
            Console.WriteLine("converted value:"+convertNotInt);

            string checkNumber = "24";
            bool b = int.TryParse(checkNumber, out int checkedNumber1);
            Console.WriteLine("Number is valid or not :"+b);
            Console.WriteLine(checkedNumber1);

            string nullValue = null;
           bool check =  int.TryParse(nullValue,out int numberNull);
            Console.WriteLine(numberNull);
            Console.WriteLine(check);

            Console.WriteLine("---------END--------- ");
        }

        private static void intParse()
        {
            Console.WriteLine("---------int.Parse--------- ");
            //convert string to integer
            //cannot handle null values
            //will not check number valid or not
            string value = "123";
           // string valueNotInt = "aa123b";

            int number1=int.Parse(value);
            //int number2=int.Parse(valueNotInt);----here runtime exception occur input string not correct format
            Console.WriteLine(number1);
            //Console.WriteLine(number2);

            //string nullValue = null;
            //int numberNull = int.Parse(nullValue);
            //Console.WriteLine(numberNull);

            Console.WriteLine("---------END--------- ");
        }

        private static void converToint()
        {
            Console.WriteLine("---------Convert.ToInt32--------- ");
            //convert any datatype  to integer
            //can handle null values
            //will not check number valid or not
            string value = "123";
           // string valueNotInt = "aa123b";
            int number1=Convert.ToInt32(value);
           // int number2 = Convert.ToInt32(valueNotInt);---not work
            Console.WriteLine(number1);
           // Console.WriteLine(number2);
           string nullValue=null;
            int numberNull=Convert.ToInt32(nullValue);
            Console.WriteLine(numberNull);

        }
    }
}
