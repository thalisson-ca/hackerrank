import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static int B;
    static int H;
    static int area;
    static boolean flag;

    static{
        Scanner scanner = new Scanner(System.in);
        B = scanner.nextInt();
        scanner.nextLine();
        H = scanner.nextInt();
        scanner.close();

        flag = !(B<=0 || H<=0);
        if(!flag){
            System.out.println("java.lang.Exception: Breadth and height must be positive");
        }
    }

public static void main(String[] args){
		if(flag){
			int area=B*H;
			System.out.print(area);
		}
		
	}//end of main

}//end of class

