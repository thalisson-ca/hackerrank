using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    
 
    
static void displayPathtoPrincess(int n, String [] grid){
    
    int[] playerPosition = {(n/2),(n/2)};
    int[] objectivePosition = {0,0};
    if(grid[0][n-1]=='p'){
        objectivePosition[0] = 0;
        objectivePosition[1] = n-1;
    }else if(grid[n-1][0]=='p'){
        objectivePosition[0] = n-1;
        objectivePosition[1] = 0;
    }else if(grid[n-1][n-1]=='p'){
        objectivePosition[0] = n-1;
        objectivePosition[1] = n-1;
    }
    
    while(playerPosition[0]!=objectivePosition[0]){
        if(playerPosition[0]>objectivePosition[0]){
            playerPosition[0]--;
            Console.WriteLine("UP");
        }else{
            playerPosition[0]++;
            Console.WriteLine("DOWN");
        }
    }
    
    while(playerPosition[1]!=objectivePosition[1]){
        if(playerPosition[1]>objectivePosition[1]){
            playerPosition[1]--;
            Console.WriteLine("LEFT");
        }else{
            playerPosition[1]++;
            Console.WriteLine("RIGHT");
        }
    }
    
}
    
    
    
static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
    
     }
}
