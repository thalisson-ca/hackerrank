using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	class DisjointUnionSets
	{
		int[] rank, parent;
		int n;

		public DisjointUnionSets(int n)
		{
			rank = new int[n];
			parent = new int[n];
			this.n = n;
			makeSet();
		}

        public int countSets()
		{
			int c = 0;
			for (int i = 0; i < n; i++)
			{
				if (parent[i] == i)
				{
					c++;
				}
			}
			return c;
		}
        
		void makeSet()
		{
			for (int i = 0; i < n; i++)
			{
				parent[i] = i;
			}
		}

		public int find(int x)
		{
			if (parent[x] != x)
			{
				parent[x] = find(parent[x]);
			}

			return parent[x];
		}

		public void union(int x, int y)
		{
			
			int xRoot = find(x), yRoot = find(y);

			if (xRoot == yRoot)
				return;

			if (rank[xRoot] < rank[yRoot])
				parent[xRoot] = yRoot;

			else if (rank[yRoot] < rank[xRoot])
				parent[yRoot] = xRoot;

			else
			{
				parent[yRoot] = xRoot;
				rank[xRoot] = rank[xRoot] + 1;
			}
		}
	}

	static void Main(String[] args)
	{
		int q = Convert.ToInt32(Console.ReadLine());

		for (int a0 = 0; a0 < q; a0++)
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens_n[0]);
			int m = Convert.ToInt32(tokens_n[1]);
			long Clib = Convert.ToInt64(tokens_n[2]);
			long Croad = Convert.ToInt64(tokens_n[3]);
            
            DisjointUnionSets sets = new DisjointUnionSets(n);
			
			
			for (int a1 = 0; a1 < m; a1++)
			{
				string[] tokens_city_1 = Console.ReadLine().Split(' ');
				int city_1 = Convert.ToInt32(tokens_city_1[0])-1;
				int city_2 = Convert.ToInt32(tokens_city_1[1])-1;
                
                sets.union(city_1, city_2);
			}
			long custoTotal = -999;
			//Custo da biblioteca é menor que das estradas;
			if (Clib <= Croad)
			{
				custoTotal = Clib * n;
			}
			else
			{
				int conexao = sets.countSets();
				custoTotal = Clib * conexao + Croad * (n - conexao);
			}
			Console.WriteLine(custoTotal);
		}
	}
}
