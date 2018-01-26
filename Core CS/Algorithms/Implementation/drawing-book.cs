using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int p){
        // Complete this function
        int r=0;
        if(p<=(n/2)){ //Se a página está na primeira metade do livro
            r=p/2;
        }else{
            r=(n/2-p/2);
        }
        return r;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}
