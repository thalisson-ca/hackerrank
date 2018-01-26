using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        char[][] grid = new char[n][];
        for(int grid_i = 0; grid_i < n; grid_i++){
           grid[grid_i] = Console.ReadLine().ToCharArray();   
        }
        
        Console.WriteLine(new string(grid[0]));
        
        if(n==1){
            return;   
        }
        for(int i=1;i<n-1;i++){
            for(int j=1;j<n-1;j++){
                int ij = int.Parse(grid[i][j]+"");
                int cima = int.Parse(grid[i+1][j]+"");
                int baixo = int.Parse((grid[i-1][j]!='X')?grid[i-1][j]+"":"9");
                int esq = int.Parse(grid[i][j+1]+"");
                int dir = int.Parse((grid[i][j-1]!='X')?grid[i][j-1]+"":"9");
                
                if(ij>cima && ij>baixo && ij>esq && ij>dir){
                    grid[i][j]='X';
                }
                
            }
            Console.WriteLine(new string(grid[i]));
        }
        Console.WriteLine(new string(grid[n-1]));
        
    }
}
