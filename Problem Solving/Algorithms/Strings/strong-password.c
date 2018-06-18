#include <assert.h>
#include <limits.h>
#include <math.h>
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* https://www.hackerrank.com/challenges/strange-code/problem */

char* readline();

// Complete the minimumNumber function below.
int minimumNumber(int n, char* password) {
    // Return the minimum number of characters to make the password strong
	
	/*[THA]
	* The first thing to check is the password length, because if the word needs 4 letter
	* or more, you don't need to check the others conditions, since the others condition may already
	* be include in this +4 letters
	*/
    int result = 6-n;
		
	/*[THA]
	* Others cases are false until proven otherwise 
	*/
    bool isThereDigit = false;
    bool isThereLowerCase = false;
    bool isThereUpperCase = false;
    bool isThereSpecialCase = false;
    
	/*[THA]
	* If the word neeeds more then 4, we already have the final result
	*/
    if(result<4){ 
	    
	    /*[THA]
		* For each character in the string check if it is a digit, Upper case character,
		* Lower case character or a special character. I have choosed C because it is simple
		* to compare the characters by intervals here. If it is a match, you mark what it is here.
		*/
        for(int i=0;i<n;i++){
            if(password[i]>='0' && password[i]<='9'){
                isThereDigit = true;
            }else if(password[i]>='A' && password[i]<='Z'){
                isThereUpperCase = true;
            }else if(password[i]>='a' && password[i]<='z'){
                isThereLowerCase = true;
            }else if(password[i]=='!' || 
                password[i]=='@' ||
                password[i]=='#' ||
                password[i]=='$' ||
                password[i]=='^' ||
                password[i]=='%' ||
                password[i]=='&' ||
                password[i]=='*' ||
                password[i]=='(' ||
                password[i]==')' ||
                password[i]=='-' ||
                password[i]=='+'){
                isThereSpecialCase = true;
            }
        }
		
		/*[THA]
		* Now, we count the conditions that is satisfied.
		*/
        int contCond = 4;
        if(isThereDigit){
            contCond--;
        }
        if(isThereUpperCase){
            contCond--;
        }
        if(isThereLowerCase){
            contCond--;
        }
        if(isThereSpecialCase){
            contCond--;
        }
        
		/*[THA]
		* If the conditions that fails is more then the missing character, so the final result is
		* the number of failed conditions
		*/
        if(contCond>result){
            result = contCond;
        }
        
    }
    
    return result;
}

int main()
{
    FILE* fptr = fopen(getenv("OUTPUT_PATH"), "w");

    char* n_endptr;
    char* n_str = readline();
    int n = strtol(n_str, &n_endptr, 10);

    if (n_endptr == n_str || *n_endptr != '\0') { exit(EXIT_FAILURE); }

    char* password = readline();

    int answer = minimumNumber(n, password);

    fprintf(fptr, "%d\n", answer);

    fclose(fptr);

    return 0;
}

char* readline() {
    size_t alloc_length = 1024;
    size_t data_length = 0;
    char* data = malloc(alloc_length);

    while (true) {
        char* cursor = data + data_length;
        char* line = fgets(cursor, alloc_length - data_length, stdin);

        if (!line) { break; }

        data_length += strlen(cursor);

        if (data_length < alloc_length - 1 || data[data_length - 1] == '\n') { break; }

        size_t new_length = alloc_length << 1;
        data = realloc(data, new_length);

        if (!data) { break; }

        alloc_length = new_length;
    }

    if (data[data_length - 1] == '\n') {
        data[data_length - 1] = '\0';
    }

    data = realloc(data, data_length);

    return data;
}
