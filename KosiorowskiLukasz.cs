//Rozwiązanie zadania Projekt Eulera 48
//https://projecteuler.net/problem=48
//Wykorzystano C# Coding Conventions
//Łukasz Kosiorowski 13K3

using System;
using System.Numerics;

namespace ProjektEulera
{
	class ProjektEulera
	{
		public int Rozwiazanie1(int liczbaOstanichLiczb)
		{
			BigInteger suma = 0, _temp;
            for (int i = 1; i <= 1000; i++)
            {
                _temp = BigInteger.Pow(i, i);
                suma += _temp;
            }
			//wykorzystano operator modulo, aby pozbyć się nieznaczących cyfr
            return suma % (10 * liczbaOstanichLiczb);
		}
		
		public void Rozwiazanie2(int liczbaOstanichLiczb)
		{
			//wykorzystano operator modulo, aby pozbyć się nieznaczących cyfr
            long suma2 = 0, modulo = 10 * liczbaOstanichLiczb, _temp2;
            for (int i = 1; i <= 1000; i++)
            {
                _temp2 = i;
                for (int j = 1; j < i; j++)
                {
                    _temp2 *= i;
                    _temp2 %= modulo;
                }
                suma2 += _temp2;
                suma2 %= modulo;
            }
            return suma2;
		}
	}
	
    class Program
    {
        static void Main(string[] args)
        {
            ProjektEulera ob = new ProjektEulera();
			Console.WriteLine("Zadanie 48 Sposob1");
			Console.WriteLine(ob.Rozwiazanie1());
			
			Console.WriteLine("Zadanie 48 Sposob2");
			Console.WriteLine(ob.Rozwiazanie2();
        }
    }
}