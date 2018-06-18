using System;
using System.Collections.Generic;
using System.IO;
class Solution {
        
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] read = Console.ReadLine().Split(' ');
        int n = Int32.Parse(read[0]);
        int q = Int32.Parse(read[1]);
       
        List<List<int>> seqList = new List<List<int>>();
        for(int i=0;i<n;i++){
            seqList.Add(new List<int>());
        }
        
        int lastAnswer = 0;
        
        for(int i=0;i<q;i++){
            read = Console.ReadLine().Split(' ');
            int command = Int32.Parse(read[0]);
            int x = Int32.Parse(read[1]);
            int y = Int32.Parse(read[2]);
            if(command==1){
                int pos =((x^lastAnswer)%n);
                seqList[pos].Add(y);
            }else{
                int pos = ((x ^ lastAnswer) % n);
				List<int> lista = seqList[pos];
				lastAnswer = lista[y % (seqList[pos].Count)];
				Console.WriteLine(lastAnswer);
            }
        }
        
    }
}