using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]); //number People
        int m = Convert.ToInt32(tokens_n[1]); //Number Topic
        char[][] topic = new char[n][];
        for(int topic_i = 0; topic_i < n; topic_i++){
           topic[topic_i] = Console.ReadLine().ToCharArray();   
        }
        int maxTopic = -1;
        int numberEquipe = -1;
        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++){
                int qtdtopic = 0;
                for(int k=0;k<m;k++){
                    if(topic[i][k]=='1' || topic[j][k]=='1'){
                        qtdtopic++;
                    }
                }
                if(maxTopic<qtdtopic){
                    maxTopic=qtdtopic;
                    numberEquipe=1;
                }else if(maxTopic==qtdtopic){
                    numberEquipe++;
                }
                
            }
        }
        Console.WriteLine(maxTopic);
        Console.WriteLine(numberEquipe);
    }
}
