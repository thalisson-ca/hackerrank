using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
			int n = Convert.ToInt32(Console.ReadLine());
			string[] scores_temp = Console.ReadLine().Split(' ');
			int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
			int m = Convert.ToInt32(Console.ReadLine());
			string[] alice_temp = Console.ReadLine().Split(' ');
			int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
			// Write Your Code Here
			int[] rank = new int[n];

			int lastPontuation = scores[0];
			rank[0] = 1;


			for (int i = 1; i < n; i++)
			{
				if (scores[i] < scores[i - 1])
				{
					rank[i] = rank[i - 1] + 1;
				}
				else
				{
					rank[i] = rank[i - 1];
				}
			}


			int positionTarget = n - 1;
			for (int j = 0; j < m; j++)
			{
				int scoreAliceNow = alice[j];
                bool notFirst = false;
				for (int target = positionTarget; target >= 0; target--)
				{
					if (scoreAliceNow < scores[target])
					{
						positionTarget = target;
                        notFirst = true;
						break;
					}
				}
				if (notFirst)
				{
					Console.WriteLine(rank[positionTarget] + 1);
				}
				else
				{
					Console.WriteLine(1);
				}
			}
			Console.ReadLine();
		}
}
