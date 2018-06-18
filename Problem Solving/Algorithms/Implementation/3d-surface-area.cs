using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the surfaceArea function below.
    static int surfaceArea(int[][] A)
        {
            
            int surface = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] > 0) //Top And Bottom
                    {
                        surface += 2;
                    }
                    
                    if (i==0) //If it is Up board
                    {
                        surface += A[i][j];
                    }
                    else
                    {
                        surface += Math.Abs(A[i][j]-A[i-1][j]);
                    }

                    if (i == (A.Length - 1)){ //If it is Bottom board
                        surface += A[i][j];
                    }
                    if (j==0) //If left board
                    {
                        surface += A[i][j];
                    }
                    else
                    {
                        surface += Math.Abs(A[i][j] - A[i][j-1]);
                    }

                    if (j == A[i].Length-1) //If rigth board
                    {
                        surface += A[i][j];
                    }
                    
                }
            }

            return surface;
        }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] HW = Console.ReadLine().Split(' ');

        int H = Convert.ToInt32(HW[0]);

        int W = Convert.ToInt32(HW[1]);

        int[][] A = new int[H][];

        for (int i = 0; i < H; i++) {
            A[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
        }

        int result = surfaceArea(A);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
