using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int calculate(int x) {
        // Complete this function
        return x%11;
    }

    static void Main(String[] args) {
        int x = Convert.ToInt32(Console.ReadLine());
        int result = calculate(x);
        Console.WriteLine(result);
    }
}
