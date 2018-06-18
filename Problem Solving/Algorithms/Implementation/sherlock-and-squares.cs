using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = int.Parse(Console.ReadLine());
        for(int i=0;i<t;i++){
            string[] ab_temp = Console.ReadLine().Split(' ');
            int a = int.Parse(ab_temp[0]);
            int b = int.Parse(ab_temp[1]);
            
            int minSquare = int.Parse(Math.Floor(Math.Sqrt(a))+"");
            int maxSquare = int.Parse(Math.Floor(Math.Sqrt(b))+"");
            int count = 0;
            for(int number=minSquare; number<=maxSquare; number++){
                int square = number*number;
                if(square>=a && square<=b){
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}