using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    interface BasicContract
    {
        int Pensja();
    }

    class Contract:BasicContract
    {
        public bool ifStaz;
        public bool ifEtat;
        public int Staz;
        public int Etat;
        public int Nadgodziny;

        public Contract( bool ifstaz, bool ifetat,int staz, int etat, int natgodziny)
        {
            ifStaz = ifstaz;
            ifEtat = ifetat;
            Staz = staz;
            Etat = etat;
            Nadgodziny = natgodziny;
        }

        public Contract()
        {
            ifStaz = true;
            ifEtat = false;
            Staz = 1000;
            Etat = 5000;
            Nadgodziny = 0;
        }

        public int Pensja()
        {
            if (ifStaz == true)
            {
                return Staz;
            }
            else
            {
                return Etat + Nadgodziny * (Etat / 60);
            }
        }
    }

    class Worker 
    {
        private string Name;
        private string Surname;
        private Contract Basic;

        public Worker(string name, string surname, Contract basic)
        {
            Name = name;
            Surname = surname;
            Basic = basic;
        }

        public void ChangeContract(bool ifstaz, int staz,int etat)
        {
            if (ifstaz == true)
            {
                Basic.ifStaz = true;
                Basic.ifEtat = false;
                Basic.Staz = staz;
            }
            else
            {
                Basic.ifEtat = true;
                Basic.ifStaz = false;
                Basic.Etat = etat;
            }
        }

        public int SalaryInfo()
        {
            return Basic.Pensja();
        }

        public override string ToString()
        {
            return "Pracownik: " + Name + " " + Surname + " o pensji: " + SalaryInfo();

        }

    }
    class Program
    {
        static void Main(string[] args)

        {
            Contract b = new Contract();
            Worker a = new Worker("marcin", "wolkowicz", b);
            a.ChangeContract(false, 0, 5500);
            Console.WriteLine(a);
            a.ChangeContract(true, 50, 0);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
