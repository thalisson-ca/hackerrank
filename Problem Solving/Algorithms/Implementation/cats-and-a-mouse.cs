using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int z = Convert.ToInt32(tokens_x[2]);
            
            int dXZ = Math.Abs(x-z);
            int dYZ = Math.Abs(y-z);
            if(dXZ<dYZ){
                Console.WriteLine("Cat A");
            }else if(dXZ>dYZ){
                Console.WriteLine("Cat B");
            }else{
                Console.WriteLine("Mouse C");
            }
        }
    }
}
