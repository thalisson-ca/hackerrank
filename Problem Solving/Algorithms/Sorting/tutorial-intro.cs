using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */ 
        int v = Int32.Parse(Console.ReadLine());
        int n = Int32.Parse(Console.ReadLine());
        string[] values_arr = Console.ReadLine().Split(' ');
        
        List<int> lista = new List<int>();
        for(int i=0;i<n;i++){
            lista.Add(Int32.Parse(values_arr[i]));
        }
        
        Console.WriteLine(lista.FindIndex(x=>x==v));
    }
} 