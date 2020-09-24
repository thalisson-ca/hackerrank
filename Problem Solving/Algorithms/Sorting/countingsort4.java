import java.io.*;
import java.util.ArrayList;

public class Solution {

	//The Full Counting Sort
	//https://www.hackerrank.com/challenges/countingsort4/problem
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(bufferedReader.readLine().trim());
        int half = n/2;
        ArrayList<String>[] arr = new ArrayList[100];

        for (int i = 0; i < n; i++) {
            String[] current = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");
            int k = Integer.parseInt(current[0]);
            if(arr[k]==null) arr[k] = new ArrayList<String>();
            if(i<half) {
                arr[k].add("-");
            }else {
                arr[k].add(current[1]);
            }
            
        }
       
        StringBuilder builder = new StringBuilder(); //Don't subestimate the StringBuilder performance :)
        for(int i=0;i<arr.length;i++) {
            if(arr[i]!=null) {
                for(String str:arr[i]) {
                    builder.append(str);
                    builder.append(" ");
                }
            }
        }
        
        System.out.println(builder.toString());

        bufferedReader.close();
    }
}
