using System;
using System.Collections.Generic;

namespace Zadania_wlasne4
{
    public abstract class Character
    {
        public string Name;
        public int Lifepower;
        public int Power;

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
                return 3006;
            }
            else
            {
                return Power * Lifepower;
            }
            
        }

        public override string ToString()
        {
            return "Postać:" + Name + " o żywotności: " + Lifepower + " i sile ataku: " + NewAttackPower();
        }

    }

    class Team
    {
        private string TeamName;

        public Team( string teamname)
        {
            TeamName = teamname;
        }

        List<Character> team = new List<Character>();

        public void AddMember(Mag newmag, Warrior newwarrior) //tu być może możnaby się posłużyć Character
         {
             if (newmag != null)
             {
                 team.Add(newmag);
             }
             else
             {
                 team.Add(newwarrior);
             }

         }
        public void AddMember(Character newmember) //tu być może możnaby się posłużyć Character
        {
            team.Add(newmember);
        }

            public void ChangeMember(int number, int lifepower, int power)
        {
            team[number].Lifepower = lifepower;
            team[number].Power = power;
        }

        public int TeamPower()
        {
            int suma = 0;
            foreach(var n in team)
            {
                suma += n.Power;
            }
            return suma;
        }

        public void WriteMembers()
        {
            foreach( var n in team)
            {
                Console.WriteLine(n.Name);
            }
        }

        public override string ToString()
        {
            return "Drużyna: " + TeamName + " Ilość członków: " + team.Count + " o łączej sile: " + TeamPower();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mag a = new Mag();
            Console.WriteLine(a);
            Warrior b = new Warrior();
            Console.WriteLine(b);
            Team druzyna = new Team("Drużyna Pierścienia");
            druzyna.AddMember(a, null);
            druzyna.AddMember(null, b);
            druzyna.AddMember(a);
            druzyna.ChangeMember(0, 3, 150);
            
            Console.WriteLine(druzyna);
            druzyna.WriteMembers();
            
            /*foreach(var n in druzyna) ciekawe, tu się może przydać enumerator od kurpa!
            {

            }*/
            Console.ReadKey();
        }
    }
}
