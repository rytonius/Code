/* Description */
 
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <time.h>


#define MAX 40
#define MAXLEN 10

void clear_kb(void);

int main(void)
{
    char ch, buffer[MAX+1];
    int x = 0;
    puts("type stuff:");
    while ((ch = getchar()) != '\n' && x < MAX) {
        buffer[x++] = ch;
        printf("\nx: %d ", x);
    }
    buffer[x] = '\0';

    printf("%s\n", buffer);

    puts("fgets()");

    char bufferfgets[MAXLEN];

    puts("Enter text a line at a time; enter a blank to exit.");

    while(fgets(bufferfgets, MAXLEN, stdin))
    {
        if (bufferfgets[0] == '\n') break;

        puts(bufferfgets);
    }

    puts("flush extra excess from scanf");

    int age;
    char name1[20], name2[20];

    puts("Enter your age.");
    scanf("%d", &age);
    // clear stdin of any extra characters
    fflush(stdin);
    
    puts("Enter your first name and last seperated by a space.");
    scanf("%[^ ]%s", name1, name2);

    // display
    printf("Age: %d; name %s and %s\n", age, name1, name2);

    return 0;
}

