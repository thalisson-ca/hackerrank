using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

	public static int[] nextPosition(int[] pos, int min_i, int max_i, int min_j, int max_j)
	{
		if (pos[0] != max_i && pos[1] == min_j)
		{
			pos[0]++;
		}
		else if (pos[0] == max_i && pos[1] != max_j)
		{
			pos[1]++;
		}
		else if (pos[0] != min_i && pos[1] == max_j)
		{
			pos[0]--;
		}
		else if (pos[0] == min_i && pos[1] != min_j)
		{
			pos[1]--;
		}
		return pos;
	}


	static void Main(String[] args)
	{
		//Reading the data
		string[] reader = Console.ReadLine().Split(' ');
		int m = int.Parse(reader[0]);
		int n = int.Parse(reader[1]);
		int r = int.Parse(reader[2]);

		int[][] matrix = new int[m][];
		for (int i = 0; i < m; i++)
		{
			reader = Console.ReadLine().Split(' ');
			matrix[i] = new int[n];
			for (int j = 0; j < reader.Length; j++)
			{
				matrix[i][j] = int.Parse(reader[j]);
			}
		}

		//Calculate the number of Layers
		int L = Math.Min(m, n) / 2;

		//Rotate
		for (int Li = 0; Li < L; Li++)
		{
			int maxMov = (2 * (m + n - 4 * Li - 2));
			int Ri = r % maxMov;
			Queue<int> aux = new Queue<int>();
			
			int max_i = (m - 1) - Li;
			int max_j = (n - 1) - Li;
			int min_i = Li;
			int min_j = Li;
			int[] pos = { min_i, min_j };

			//Enqueue the first Ri elements
			while (aux.Count < Ri)
			{
				int x = pos[0];
				int y = pos[1];
				aux.Enqueue(matrix[x][y]);
				pos = nextPosition(pos, min_i, max_i, min_j, max_j);

			}
			int[] endPos = { pos[0], pos[1] }; //this is where we stop after change all the numbers

			do
			{
				int x = pos[0];
				int y = pos[1];
				aux.Enqueue(matrix[x][y]);
				matrix[x][y] = aux.Dequeue();
				pos = nextPosition(pos, min_i, max_i, min_j, max_j);
			} while (!(endPos[0]==pos[0] && endPos[1]==pos[1]));
						
		}

		//Print Matrix

		for (int i = 0; i < m; i++)
		{
			string response = "";
			for (int j = 0; j < n; j++)
			{
				response += matrix[i][j] + " ";
			}
			Console.WriteLine(response);
		}


	}
}