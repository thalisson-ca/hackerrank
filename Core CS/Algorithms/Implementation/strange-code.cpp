#include <bits/stdc++.h>

using namespace std;

//https://www.hackerrank.com/challenges/strange-code/problem

// Complete the strangeCounter function below.
long strangeCounter(long t) {
    long f = 3;
    long sum = 0;
    do{
        sum+= f;
        f*=2;
    }while(sum<t);
    return (sum-t+1);

}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    long t;
    cin >> t;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    long result = strangeCounter(t);

    fout << result << "\n";

    fout.close();

    return 0;
}
