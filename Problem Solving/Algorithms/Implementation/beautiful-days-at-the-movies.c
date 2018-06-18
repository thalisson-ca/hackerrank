#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int reverseNumber(int number){
    int reverse = 0;
    while(number!=0){
        reverse=reverse*10;
        reverse = reverse+number%10;
        number = number/10;
    }
    return reverse;
}

int main() {

    /* Enter your code here. Read input from STDIN. Print output to STDOUT */    
    int i, j, k;
    scanf("%i %i %i",&i,&j,&k);
    int c=0;
    for(int x=i;x<=j;x++){
        if((x-reverseNumber(x))%k==0){
            c++;
        }
    }
    printf("%i",c);
    
    
    return 0;
}
