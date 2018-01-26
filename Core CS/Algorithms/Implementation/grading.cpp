#include <bits/stdc++.h>

using namespace std;

vector < int > solve(vector < int > grades){
    // Complete this function
    vector<int> result(grades.size());
    for(int p=0;p<grades.size();p++){
        int value = grades[p];
        int mod5 = value%5;
        if(value>=38 && mod5>=3){
            value=value+(5-mod5);
        }
        result[p]=value;
    }
    return result;
}

int main() {
    int n;
    cin >> n;
    vector<int> grades(n);
    for(int grades_i = 0; grades_i < n; grades_i++){
       cin >> grades[grades_i];
    }
    vector < int > result = solve(grades);
    for (ssize_t i = 0; i < result.size(); i++) {
        cout << result[i] << (i != result.size() - 1 ? "\n" : "");
    }
    cout << endl;
    

    return 0;
}
