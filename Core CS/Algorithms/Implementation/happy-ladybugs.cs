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
	//https://www.hackerrank.com/challenges/happy-ladybugs/problem
	
    
    // Complete the happyLadybugs function below.
    static string happyLadybugs(string b) {
        //The ladybug game can be won if the following conditions can be met:
        //1. Each color in game must have at least 2 ladybugs. 
        //2.1 The initial position of the ladybugs already make all of them happy
        //2.2 If the initial position doesn't make all of them happy, must have at least 1 space
        
        bool allColorHaveMoreThan2Ladybugs = false;
        bool allLadybugsAreHappy = true;
        bool thereIsAtLeast1Space = false;
        
        Dictionary<char, bool> colors = new Dictionary<char, bool>(); 
        
        char prevChar = '_';
        bool prevStat = true;
        
        foreach(char character in b){
            //Check if it is a space
            if(character=='_'){
                thereIsAtLeast1Space = true;
            }else{
                //Check if there is more than 1 ladybug
                if(!colors.ContainsKey(character)){
                    colors.Add(character,false);
                }else{
                    colors[character] = true;
                }
                
                bool currentStat = character==prevChar;
                if(currentStat==false && prevStat==false){
                    allLadybugsAreHappy = false;
                }
                prevStat = currentStat;
                
            }
            prevChar = character;
            
        }
        
        allColorHaveMoreThan2Ladybugs = !colors.ContainsValue(false);
        
        if(allColorHaveMoreThan2Ladybugs && 
            (allLadybugsAreHappy ||
            (!allLadybugsAreHappy && thereIsAtLeast1Space))){
            return "YES";
        }else{
            return "NO";
        }

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine());

        for (int gItr = 0; gItr < g; gItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            string b = Console.ReadLine();

            string result = happyLadybugs(b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
