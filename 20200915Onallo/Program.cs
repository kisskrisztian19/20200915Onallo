using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200915Onallo
{
    class Teglalap
    {
        int a, b;
        public Teglalap(int aa, int bb)
        {
            a = aa; b = bb;
        }
        public int szamitker()
        {
            return a * b;
        }
        public int szamitter()
        { 
            return 2 * (a * b);
        }
    }
    class Kor
    {
        private int r;

        public Kor(int sugar) //Konstruktor
        {
            if (sugar < 1)
            {
                r = 1;
            } else r = sugar;

        }

        public double kerulet() 
        {
            return 2 * r * Math.PI;
        }
        public double terulet()
        {
           return Math.Pow(r, 2) * Math.PI;
        }
        public void Adatok()
        {
            Console.WriteLine($"Sugár: {r} Terület: {terulet()} Kerület {kerulet()}");
        }
    }
    class Program
    {
        static void Teglaszamitas()
        {
            Console.WriteLine("Add meg az oldalakat:");
            Console.Write("A: "); int a = int.Parse(Console.ReadLine());
        Console.WriteLine();
            Console.Write("B: "); int b = int.Parse(Console.ReadLine());
        Teglalap szamitas = new Teglalap(a, b);

            Console.WriteLine($"Kerület: {szamitas.szamitker()} Terület: {szamitas.szamitter()}"); 
        }
        static void Korszamitas()
        {
            
            Console.Write("Adja meg a kör sugarát: "); int r = int.Parse(Console.ReadLine());
            Kor korocske = new Kor(r);
            //korocske.r = r;
            korocske.Adatok(); 
        }
        static void Main(string[] args)
        {
            Teglaszamitas();
            Korszamitas();
            Console.ReadLine();
        }
    }
}
