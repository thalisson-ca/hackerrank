using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s){
        // Complete this function

        Regex rgx = new Regex(@"([a-z])\1");
        string result = s;
        string ant = "";
        
        do{
            ant = result;
            result = rgx.Replace(result, "");
        }while(result!=ant);
        
        if(result.Length==0){
            result = "Empty String";
        }
        
        return result;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}
