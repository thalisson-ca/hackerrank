using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        string[] entries = Console.ReadLine().Split(' ');

			BigInteger t1 = new BigInteger(int.Parse(entries[0]));
			BigInteger t2 = new BigInteger(int.Parse(entries[1]));
			int n = int.Parse(entries[2]);

			BigInteger[] fibo = new BigInteger[n];
			fibo[0] = t1;
			fibo[1] = t2;

			for (int i = 0; i < n - 2; i++)
			{
				fibo[i + 2] = BigInteger.Add(fibo[i] , BigInteger.Pow(fibo[i + 1],2));
			}

			Console.WriteLine(fibo[n - 1].ToString());
        
    }
}
}
