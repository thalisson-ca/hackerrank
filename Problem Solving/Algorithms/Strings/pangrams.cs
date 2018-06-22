using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the pangrams function below.
    static string pangrams(string s) {
            string response = "";
            string newS = s.ToLower();
            HashSet<char> alpha = new HashSet<char>();
            foreach(char c in newS)
            {
                if(Char.IsLetter(c))
                {
                    alpha.Add(c);
                }
            }

            if (alpha.Count < 26)
            {
                response = "not pangram";
            }else{
                response = "pangram";
            }

            return response;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
