import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
	//Sherlock and Anagrams
	//https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem

	static final  Hashtable<Character, BigInteger> lt = new Hashtable<Character, BigInteger>();
	
	static BigInteger factorial(int n) {
		
		BigInteger r = BigInteger.ONE;
		for(int i=2;i<=n;i++) {
			r = r.multiply(new BigInteger(i+""));
		}
		return r;
	}
	
    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(char[] s) {
    	
    	int count = 0;
    	Hashtable<BigInteger,Integer> set = new Hashtable<BigInteger,Integer>();
    	
    	for(int size=0;size<s.length;size++) {
    		for(int i=0;i<s.length-size;i++) {
    			BigInteger hashI = BigInteger.ONE;
    			for(int p=0;p<=size;p++) {
    				hashI = hashI.multiply(Solution.lt.get(s[i+p]));
    			}
    			
    			if(set.containsKey(hashI)) {
    				set.put(hashI, set.get(hashI)+1);
    			}else {
    				set.put(hashI, 1);
    			}
    			
    		}
    	}
    	
    	for(Integer n:set.values()) {
    		if(n>1) {
    			count += ((factorial(n)).divide((new BigInteger("2")).multiply(factorial(n-2)))).intValueExact() ;
    		}
    	}
    	
    	return count;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
    	lt.put('a', new BigInteger("2"));
    	lt.put('b', new BigInteger("3"));
    	lt.put('c', new BigInteger("5"));
    	lt.put('d', new BigInteger("7"));
    	lt.put('e', new BigInteger("11"));
    	lt.put('f', new BigInteger("13"));
    	lt.put('g', new BigInteger("17"));
    	lt.put('h', new BigInteger("19"));
    	lt.put('i', new BigInteger("23"));
    	lt.put('j', new BigInteger("29"));
    	lt.put('k', new BigInteger("31"));
    	lt.put('l', new BigInteger("37"));
    	lt.put('m', new BigInteger("41"));
    	lt.put('n', new BigInteger("43"));
    	lt.put('o', new BigInteger("47"));
    	lt.put('p', new BigInteger("53"));
    	lt.put('q', new BigInteger("59"));
    	lt.put('r', new BigInteger("61"));
    	lt.put('s', new BigInteger("67"));
    	lt.put('t', new BigInteger("71"));
    	lt.put('u', new BigInteger("73"));
    	lt.put('v', new BigInteger("79"));
    	lt.put('w', new BigInteger("83"));
    	lt.put('x', new BigInteger("89"));
    	lt.put('y', new BigInteger("97"));
    	lt.put('z', new BigInteger("101"));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
        StringBuffer sb = new StringBuffer();
        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();
            sb.append(sherlockAndAnagrams(s.toCharArray()));
            sb.append("\n");
        }
       
        bufferedWriter.write(sb.toString());
        bufferedWriter.newLine();
        bufferedWriter.close();

        scanner.close();
    }
}
