using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]); //Size of board
        int k = Convert.ToInt32(tokens_n[1]); //Number of obst
        string[] tokens_rQueen = Console.ReadLine().Split(' ');
        int rQueen = Convert.ToInt32(tokens_rQueen[0]); //Row queen
        int cQueen = Convert.ToInt32(tokens_rQueen[1]); //Collumn queen
        int dUp = n-rQueen;
        int dDown = rQueen-1;
        int dLeft = cQueen-1;
        int dRight = n-cQueen;
        int dUpLeft = Math.Min(dUp,dLeft);
        int dDownLeft= Math.Min(dDown,dLeft);
        int dDownRight= Math.Min(dDown,dRight);
        int dUpRight= Math.Min(dUp,dRight);
        
        for(int a0 = 0; a0 < k; a0++){
            string[] tokens_rObstacle = Console.ReadLine().Split(' ');
            int rObstacle = Convert.ToInt32(tokens_rObstacle[0]);
            int cObstacle = Convert.ToInt32(tokens_rObstacle[1]);
            int rDif = rQueen-rObstacle;
            int cDif = cQueen-cObstacle;
            int v;
            
            if(cDif==0){ //Vertical
                v=Math.Abs(rDif)-1;
                if(rDif<0){//Up
                    if(dUp>v){
                        dUp=v;
                    }
                }else{ //Down
                    if(dDown>v){
                        dDown=v;
                    }
                }
                
            }else if(rDif==0){
                v=Math.Abs(cDif)-1;
                if(cDif<0){//Right
                    if(dRight>v){
                        dRight=v;
                    }
                }else{ //Left
                    if(dLeft>v){
                        dLeft=v;
                    }
                }
            }else if(Math.Abs(rDif)==Math.Abs(cDif)){
                v=Math.Abs(rDif)-1;
                if(rDif<0 && cDif<0){ //UpRight
                    if(dUpRight>v){
                        dUpRight=v;
                    }
                }else if(rDif>0 && cDif>0){ //DownLeft
                    if(dDownLeft>v){
                        dDownLeft=v;
                    }
                }else if(rDif<0 && cDif>0){ //UpLeft
                    if(dUpLeft>v){
                        dUpLeft=v;
                    }
                }else{
                    if(dDownRight>v){
                        dDownRight=v;
                    }
                }
                
            }
          
        }
        
        Console.WriteLine(dUp+dLeft+dDown+dRight+dUpLeft+dUpRight+dDownLeft+dDownRight);
        
    }
}
