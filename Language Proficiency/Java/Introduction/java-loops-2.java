import java.util.*;
import java.io.*;
import java.lang.Math;

class Solution{
    public static void main(String []argh){
        Scanner in = new Scanner(System.in);
        int t=in.nextInt();
        for(int i=0;i<t;i++){
            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();

            String result="";
            int r = a;
            for(int j=0;j<n;j++){
                r+= Math.pow(2,j)*b;
                result += r+" ";
            }
            System.out.println(result.trim());
        }
        in.close();
    }
}

