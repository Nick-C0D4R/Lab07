using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            #region Task1
            //Func<double, double, double> Add = (a, b) => a + b;
            //Func<double, double, double> Sub = (a, b) => a - b;
            //Func<double, double, double> Mul = (a, b) => a * b;
            //Func<double, double, double> Div = (a, b) => { if (b != 0) return a / b; else throw new ArgumentException("b is zero"); };

            //Console.WriteLine(Add(1,3).ToString());
            //Console.WriteLine(Sub(1,3).ToString());
            //Console.WriteLine(Mul(1,3).ToString());
            //Console.WriteLine(Div(1,3).ToString());
            #endregion

            #region Task2
            //func<func<int>[], int> randaverage = (delegates) =>
            //{
            //    int sum = 0;
            //    foreach(var item in delegates)
            //    {
            //        sum += item();
            //    }
            //    return sum / delegates.length;
            //};

            //func<int>[] arr =
            //{
            //    () => rand.next(0, 11),
            //    () => rand.next(0, 11),
            //    () => rand.next(0, 11),
            //    () => rand.next(0, 11),
            //    () => rand.next(0, 11)
            //};

            //console.writeline(randaverage(arr));
            #endregion

            #region Task3
            Func<int, int, int, int> func = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };
            Console.WriteLine(func(3, 4, 5));
            #endregion
        }
    }
}
