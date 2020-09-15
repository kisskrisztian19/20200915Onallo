using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200915Onallo
{
    class Teglalap
    {
        public int szamitker(int a, int b)
        {
            return a * b;
        }
        public int szamitter(int a, int b)
        { 
            return 2 * (a * b);
        }
    }
    class Kor
    {
        private double r;

        public Kor(int sugar) //Konstruktor
        {
            r = sugar;
        }

        public double kerulet() 
        {
            return 2 * r * Math.PI;
        }
        public double terulet()
        {
           return Math.Pow(r, 2) * Math.PI;
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
        Teglalap szamitas = new Teglalap();

            Console.WriteLine($"Kerület: {szamitas.szamitker(a, b)} Terület: {szamitas.szamitter(a, b)}"); 
        }
        static void Korszamitas()
        {
            Kor korocske = new Kor();
            Console.Write("Adja meg a kör sugarát: "); double r = int.Parse(Console.ReadLine());
            korocske.r = r;

            Console.WriteLine($"A kör kerülete: {korocske.kerulet()} területe: {korocske.terulet()}"); 
        }
        static void Main(string[] args)
        {
            Teglaszamitas();
            Korszamitas();
            Console.ReadLine();
        }
    }
}
