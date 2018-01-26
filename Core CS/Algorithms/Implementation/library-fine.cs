using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_d1 = Console.ReadLine().Split(' ');
        int d1 = Convert.ToInt32(tokens_d1[0]);
        int m1 = Convert.ToInt32(tokens_d1[1]);
        int y1 = Convert.ToInt32(tokens_d1[2]);
        string[] tokens_d2 = Console.ReadLine().Split(' ');
        int d2 = Convert.ToInt32(tokens_d2[0]);
        int m2 = Convert.ToInt32(tokens_d2[1]);
        int y2 = Convert.ToInt32(tokens_d2[2]);
        
        DateTime devolucao = new DateTime(y1,m1,d1);
        DateTime validade = new DateTime(y2,m2,d2);
        
        int custo = 0;
        if(devolucao<=validade){
            custo=0;
        }else if(devolucao.Year==validade.Year){
            if(devolucao.Month==validade.Month){
                custo = 15*(devolucao.Day-validade.Day);
            }else{
                custo = 500*(devolucao.Month-validade.Month);
            }
        }else{
            custo=10000;
        }
        
        Console.WriteLine(custo);
            
    }
}
