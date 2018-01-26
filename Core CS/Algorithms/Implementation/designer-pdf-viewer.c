#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int main(){
    int *h = malloc(sizeof(int) * 26);
    for(int h_i = 0; h_i < 26; h_i++){
       scanf("%d",&h[h_i]);
    }
    char* word = (char *)malloc(512000 * sizeof(char));
    scanf("%s",word);
    
    int wordLengh = 0;
    int hmax=0;
    while(word[wordLengh]!='\0'){
        int letter = word[wordLengh]-97;
        if(hmax<h[letter]){
            hmax=h[letter];
        }
        wordLengh++;
    }
    
    printf("%i",wordLengh*hmax);
    return 0;
}
