using System;

namespace Zadania_wlasne4
{
    public abstract class Character
    {
        protected string Name;
        protected int Lifepower;
        protected int Power;

        public Character(string name, int lifepower, int power)
        {
            Name = name;
            Lifepower = lifepower;
            Power = power;
        }

        public Character()
        {
            Name = "Geralt";
            Lifepower = 100;
            Power = 3006;
        }

        abstract public int AddPower(string znak, int x);
        abstract public int NewAttackPower();


    }

    public class Mag : Character
    {
        private int MagicForce;

        public Mag(string name, int lifepower, int power, int magicforce) : base(name, lifepower, power)
        {
            Name = name;
            Lifepower = lifepower;
            Power = power;
            MagicForce = magicforce;
        }

        public Mag() : base()
        {
            Name = "Xardas";
            Lifepower = 100;
            Power = 1006;
            MagicForce = 2006;

        }

        public override int AddPower(string znak, int x)
        {
            if (znak == "+")
            {
                if (Lifepower + x > 100)
                {
                    return Lifepower = 100;
                }
                else
                {
                    return Lifepower = Lifepower + x;
                }
            }
            else
            {
                if (Lifepower - x < 0)
                {
                    return Lifepower = 0;
                }
                else
                {
                    return Lifepower = Lifepower - x;
                }
            }


        }

        public override int NewAttackPower()
        {
            return (MagicForce + Power) * Lifepower;
        }

        public override string ToString()
        {
            return "Postać:" + Name + " o żywotności: " + Lifepower + " i sile ataku: " + NewAttackPower();
        }
    }

    class Warrior : Character
    {
        public Warrior(string name, int lifepower, int power, int magicforce) : base(name, lifepower, power)
        {
            Name = name;
            Lifepower = lifepower;
            Power = power;

        }

        public Warrior() : base()
        {
            Name = "Geralt";
            Lifepower = 100;
            Power = 3006;

        }
        public override int AddPower(string znak, int x)
        {
            if (znak == "+")
            {
                if (Lifepower + x > 100)
                {
                    return Lifepower = 100;
                }
                else
                {
                    return Lifepower = Lifepower + x;
                }
            }
            else
            {
                if (Lifepower - x < 0)
                {
                    return Lifepower = 0;
                }
                else
                {
                    return Lifepower = Lifepower - x;
                }
            }

        }
        public override int NewAttackPower()
        {
            if (Lifepower < 5)
            {
                return 0;
            }
            else
            {
                return Power * Lifepower;
            }
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mag a = new Mag();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
