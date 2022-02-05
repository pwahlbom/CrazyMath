using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyMath
{
    public class MathClass
    {

        public int doSomething(int number1, int number2)
        {
            //divide
            return number1 / number2;
        }

        public int doSomething(int number1, int number2, int number3)
        {
            //add
            return number1 + number2 + number3;
        }

        public int doSomething(int number1, int number2, int number3, int number4)
        {
            //multiply
            return number1 * number2 * number3 * number4;
        }


        public int doSomething(params int[] numbers)
        {

            var intTotal = 0;

            foreach (var number in numbers)
            {
                intTotal = intTotal + number;
            }

            return intTotal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var clsNum1 = new MathClass();
            var MySum1 = clsNum1.doSomething(6,2);

            var clsNum2 = new MathClass();
            var MySum2 = clsNum2.doSomething(3,3,3);

            var clsNum3 = new MathClass();
            var MySum3 = clsNum3.doSomething(2,2,2,2);

            Console.WriteLine(MySum1);
            Console.WriteLine(MySum2);
            Console.WriteLine(MySum3);
            Console.ReadLine();

        }
    }
}
