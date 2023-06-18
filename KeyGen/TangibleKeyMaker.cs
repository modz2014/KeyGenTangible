using System;
using System.Collections.Generic;

namespace KeyGen;

internal class TangibleKeyGen
{
	private static List<int> primes;

	private static Random r;

	static TangibleKeyGen()
	{
		primes = new List<int>();
		r = new Random();
		buildPrimeList();
	}

	public static string generateKey()
	{
		int num = primes[r.Next(primes.Count)];
		int num2 = primes[r.Next(primes.Count)];
		int num3 = primes[r.Next(primes.Count)];
		char[] array = new char[15];
		array[0] = (char)(48 + int.Parse(num.ToString().Substring(0, 1)));
		array[1] = (char)(48 + r.Next(1, int.Parse(array[0].ToString())));
		array[2] = (char)(48 + r.Next(0, int.Parse(array[1].ToString())));
		array[3] = (char)(48 + int.Parse(num2.ToString().Substring(0, 1)));
		array[4] = (char)(48 + int.Parse(num2.ToString().Substring(1, 1)));
		array[5] = (char)(65 + r.Next(0, 26));
		array[6] = (char)(65 + r.Next(0, 26));
		array[7] = (char)(48 + int.Parse(num3.ToString().Substring(0, 1)));
		array[8] = (char)(48 + int.Parse(num3.ToString().Substring(1, 1)));
		array[9] = '8';
		array[10] = 'D';
		array[11] = 'V';
		array[12] = 'T';
		array[14] = (char)(48 + int.Parse(num.ToString().Substring(1, 1)));
		array[13] = (char)(48 + r.Next(0, int.Parse(array[14].ToString())));
		return new string(array);
	}

	public static string generateOrderNumber()
	{
		return new Random().Next(10000, 80000).ToString();
	}

	private static void buildPrimeList()
	{
		for (int i = 30; i <= 100; i++)
		{
			if (isPrime(i))
			{
				primes.Add(i);
			}
		}
	}

	private static bool isPrime(int _p0)
	{
		double num = Math.Sqrt(_p0);
		for (int i = 2; (double)i <= num; i++)
		{
			double num2 = (double)_p0 / (double)i;
			if (Math.Floor(num2) == num2)
			{
				return false;
			}
		}
		return true;
	}
}
