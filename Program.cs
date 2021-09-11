using System;
using System.Linq;

namespace dzshka
{
    class C_residential_quarter : IComparable<C_residential_quarter>
    {
        public C_residential_quarter()
        {
            m = 1;
            j = 1;
            y = 1;
        }
        public C_residential_quarter(int _m, int _j, int _y)
        {
            m = _m;
            j = _j;
            y = _y;
        }
        public void show()
        {
            Console.Write("Этажей: " + m + ", ");
            Console.Write("Квартир: " + j + ", ");
            Console.Write("Жильцов: " + y + ". \n");
        }

        public int n; // дома
        public int m; // этажи
        public int j; // квартиры
        public int y; // жильцы
        public int CompareTo(C_residential_quarter rq)
        {
            return this.y.CompareTo(rq.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C_residential_quarter house1 = new C_residential_quarter(6, 72, 163);
            //house1.show();
            C_residential_quarter house2 = new C_residential_quarter(12, 432, 357);
            //house2.show();
            C_residential_quarter house3 = new C_residential_quarter(5, 15, 15);
            //house3.show();

            C_residential_quarter[] houses = new C_residential_quarter[] { house1, house2, house3 };
            Array.Sort(houses);

            foreach (C_residential_quarter p in houses)
            {
                Console.Write("Этажей: " + p.m + ", ");
                Console.Write("Квартир: " + p.j + ", ");
                Console.Write("Жильцов: " + p.y + ".\n");
            }

            int max = houses.Max().y;
            Console.Write("\nСамое большое количество жильцов: " + max + ".\n");
            int min = houses.Min().y;
            Console.Write("\nСамое меньшее количество жильцов: " + min + ".\n");

            Console.ReadKey();
        }
    }
}