using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] param = Console.ReadLine().Split(' ');
        int n = int.Parse(param[0]);
        int k = int.Parse(param[1]);
        
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse); 
        
        bool thereIsMiddle = (k%2==0);
        
        List<int>[] conjuntos = new List<int>[k];
        for(int i=0;i<k;i++){
            conjuntos[i] = new List<int>();
        }
        
        
        for(int i=0;i<n;i++){
            int valor = a[i];
            conjuntos[valor%k].Add(valor);
        }
        
        int result = 0;
        int limit = k/2;
        
        //Caso 0
        if(conjuntos[0].Count>0){
                result++;
        }
        
        //Caso meio
        if(thereIsMiddle){
            if(conjuntos[k/2].Count>0){
                result++;
            }
            limit--;
        }
        
        
        for(int i=1;i<=limit;i++){
            int valorA = conjuntos[i].Count;
            int valorB = conjuntos[k-i].Count;
            result+=Math.Max(valorA,valorB);
            
        }
        
        Console.WriteLine(result);
        
    }
}