using System;

namespace dzshka
{
    class C_residential_quarter
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

        public int n; // doma
        public int m; // etajy
        public int j; // kvartiry
        public int y; // ludi
    }

    class Program
    {
        static void Main(string[] args)
        {
            C_residential_quarter house1 = new C_residential_quarter(1, 1, 1);
            house1.show();
            C_residential_quarter house2 = new C_residential_quarter(1, 1, 1);
            house2.show();
            C_residential_quarter house3 = new C_residential_quarter(1, 1, 1);
            house3.show();

            Console.ReadKey();
        }
    }
}