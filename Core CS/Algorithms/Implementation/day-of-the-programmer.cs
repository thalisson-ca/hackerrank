using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string solve(int year){
        // Complete this function
        //Se calendário Gregoriano
        string resposta;
        if(year>1918){
            if((year%4==0 && year%100!=0) || (year%400==0)){
                resposta="12.09."+year;
            }else{
                resposta="13.09."+year;
            }
        }else if(year<1918){ //Se Juliano
            if(year%4==0){
                resposta="12.09."+year;
            }else{
                resposta="13.09."+year;
            }
        }else{ //Se transição
            resposta="26.09."+year;
        }
        
        return resposta;
    }

    static void Main(String[] args) {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}
