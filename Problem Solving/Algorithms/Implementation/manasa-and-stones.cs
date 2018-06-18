using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = int.Parse(Console.ReadLine());
        for(int test=0;test<t;test++){
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            SortedSet<int> setNumbers = new SortedSet<int>();
            for(int i=0;i<n;i++){
                int Na = i;
                int Nb = (n-1)-Na;
                int total = a*Na+b*Nb;
                setNumbers.Add(total);
            }
            
            foreach(int k in setNumbers){
                Console.Write(k+" ");
            }
            Console.Write("\n");
        }
    }
}