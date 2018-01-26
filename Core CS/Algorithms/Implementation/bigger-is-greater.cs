using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = int.Parse(Console.ReadLine());
        
        for(int i=0;i<t;i++){
            string response = "no answer";
            char[] s= Console.ReadLine().ToCharArray();
           
            //pivot
            int pivo = s.Length-2;
            
            for(int x=s.Length-1;x>0;x--){
                if(s[pivo]<s[x]){
                    break;
                }else{
                    pivo--;
                }
            }
            if(pivo>-1){
                
                int proxPivo=-1;
                for(int x=s.Length-1;x>pivo;x--){
                    if((s[x]-s[pivo])>0){
                        if(proxPivo==-1 || s[proxPivo]>s[x]){
                            proxPivo=x;
                        }
                    }
                }

                char aux = s[pivo];
                s[pivo]=s[proxPivo];
                s[proxPivo]=aux;

                int k=1;
                for(int j=pivo+1;j<=(s.Length-k);j++){
                    aux = s[j];
                    s[j]=s[s.Length-k];
                    s[s.Length-k]=aux;
                    k++;
                }
                
                response = new string(s);
                
            }
            Console.WriteLine(response);
        }
        
    }
}