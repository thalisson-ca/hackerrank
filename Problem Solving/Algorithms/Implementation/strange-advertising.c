#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {

    /* Enter your code here. Read input from STDIN. Print output to STDOUT */  
    int n;
    scanf("%i",&n);
    int total=2, qtd=2;
    
    for(int i=2;i<=n;i++){
        qtd = (qtd*3)/2;
        total+=qtd;
    }
    printf("%i",total);
    return 0;
}
