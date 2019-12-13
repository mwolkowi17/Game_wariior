using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    abstract class Figure
    {
        public string NameType;

        abstract public double Obwod();
        abstract public double Pole();
        abstract public object Clone();

        abstract public void Przesun(int xA,int yA);
       
    }
    interface IKonsola
    {
       void Wczytaj();
        void Wpisz();
    }

    

    class Point : Figure,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            NameType = "point";
            X = 1;
            Y = 1;
        }
        public Point(string name, int x, int y)
        {
            NameType = name;
            X = y;
            Y = x;
        }
        public override double Obwod()
        {
            return 0;
        }
        public override double Pole()
        {
            return 0;
        }
        public override void Przesun(int xA,int yA)
        {
            X=X+xA;
            Y = Y+yA;
        }
        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public double OdlegloscPoziom (Point a)
        {
            return X + a.X;
        }

       
        
        public override string ToString()
        {
            return NameType + " o współrzędnych: "+X+" "+Y;
        }
    }
    class Trojkat:Figure,ICloneable
    {
        private Point X1;
        private Point Y2;
        private Point Z3;

        public Trojkat()
        {
            NameType = "Trojkat";
            X1 = new Point("A",2, 3);
            Y2 = new Point("B", 3, 4);
            Z3 = new Point("C", 5, 6);
        }
        public Trojkat(Point x, Point y, Point z)
        {
            NameType = "TrojkatNew";
            X1 = x;
            Y2 = y;
            Z3 = z;
        }

        public override double Pole()
        {
            return 35; //wzór na pole powinien być;
        }
        public override double Obwod()
        {
            return 70; //wzór na obwód powinien być;
        }

        public override void Przesun(int xA, int yA)
        {
            Console.WriteLine("wzór przesunięcia powinien być"); 
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return NameType + " o współrzędnych: " + X1.X + X1.Y + Y2.X + Y2.Y + Z3.X + Z3.Y;
        }
    }

    class Kolo:Figure,ICloneable,IKonsola
    {
        private int Promien;
        private Point Srodek;

        public Kolo()
        {
            NameType = "Kolo";
            Promien = 3;
            Srodek = new Point("Punkt",3, 4);
        }

        public Kolo(int r, Point s)
        {
            NameType = "New Kolo";
            Promien = r;
            Srodek = s;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public override double Obwod()
        {
            return 45;
        }

        public override double Pole()
        {
           return 90;
        }

        public override void Przesun(int xA, int yA)
        {
            Console.WriteLine("Nowy współrzędne srodk") ;
        }

        public override string ToString()
        {
            return NameType + " o promieniu: " + Promien;
        }

        public void Wczytaj()
        {
            string x;
            x = Console.ReadLine();
        }

        public void Wpisz()
        {
           string x;
            x = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point("punkt", 3, 4);
            Console.WriteLine(a);
            Trojkat b = new Trojkat();
            Console.WriteLine(b);
            Kolo c = new Kolo();
            Console.WriteLine(c);

        
            Console.ReadKey();
        }
    }
}
