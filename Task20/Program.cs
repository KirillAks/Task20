using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        /*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
         * - метод получает входным параметром переменную типа double;
         - метод возвращает значение типа double, которое является результатом вычисления.
        Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        - длину окружности по формуле D = 2 * π* R;
        - площадь круга по формуле S = π* R²;
        - объем шара. Формула V = 4/3 * π * R³.
        Методы должны быть объявлены как статические.*/
        
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Circumference;
            myDelegate += AreaCircle;
            myDelegate += BallVolume;
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            myDelegate(r);
            Console.ReadKey();
        }

        static double Circumference(double r)
        {
            double l = 2 * r * Math.PI;
            Console.WriteLine($"Длина окружности равна {l}");
            return l;
        }
        static double AreaCircle(double r)
        {
            double s = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine($"Площадь круга равна {s}");
            return s;
        }
        static double BallVolume(double r)
        {
            double v = Math.Pow(r, 3) * Math.PI * 4 / 3;
            Console.WriteLine($"Объем шара равен {v}");
            return v;
        }
    }
}
