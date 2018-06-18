using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Int32.Parse(Console.ReadLine());
        string steps = Console.ReadLine();
        
        var enuma = steps.GetEnumerator();
        int altitude = 0;
        int count = 0;
       while(enuma.MoveNext()){
           char step = enuma.Current;
           if(step=='U'){
               altitude++;
           }else{
               altitude--;
               if(altitude==-1){
                   count++;
               }
           }             
        }
        Console.Write(count);
    }
}