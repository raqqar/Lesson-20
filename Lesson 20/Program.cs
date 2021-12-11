using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20
{
    ////    1.В приложении объявить тип делегата, который ссылается на метод.
    ///Требования к сигнатуре метода следующие:
    ////-метод получает входным параметром переменную типа double;
    ////-метод возвращает значение типа double, которое является результатом вычисления.
    ////Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
    ////-длину окружности по формуле D = 2 * π * R;
    ////-площадь круга по формуле S = π* R²;
    ////-объем шара.Формула V = 4 / 3 * π * R³.
    ////Методы должны быть объявлены как статические.
    internal class Program
    {
        delegate double MyDelegate(double r);

       

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = new MyDelegate(circumFerence);
            
            double cf=myDelegate(r);
            Console.WriteLine("длина окружности равна {0}", cf);

            myDelegate = circulArea;
            double ca = myDelegate(r);
            Console.WriteLine("площадь круга равнв {0}", ca);

            myDelegate = volumeBoll;
            double vb = myDelegate(r);
            Console.WriteLine("объем шара равен {0}", vb);

            Console.ReadLine();
        }
        private static double circumFerence(double r)
        {
            double D = 2 * Math.PI * r;
            return D;
        }
        private static double circulArea(double r)
        {
            double S = 2 * Math.PI * r;
            return S;
        }
        private static double volumeBoll(double r)
        {
            
            double V = (4 * Math.PI * Math.Pow(r,3)/3);
            return V;
        }
    }
     
}
