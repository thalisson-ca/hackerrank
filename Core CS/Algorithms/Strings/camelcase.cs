using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int count = 1;
        foreach (char c in s){
            if (char.IsUpper(c)) count++;
        }
        Console.WriteLine(count);
    }
}
