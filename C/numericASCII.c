/* Description */

#include <stdio.h>

int allASCII();

char c1 = 'a';
char c2 = 90;

int main()
{
    // Print variable C1 as a character , then as a number

    printf("\nAs a character, variable c1 is %c", c1);
    printf("\nAs a number, variable c1 is %d", c1);

    // Do the same for variable c2

    printf("\nAs a character, variable c2 is %c", c2);
    printf("\nAs a number, variable c2 is %d\n", c2);

    allASCII();

    return 0;
}

int allASCII()
{
    unsigned char x; // must be unsigned for extended ASCII

    // Print extended ASCII characters 180 through 203
    puts("hiya");
    for (x = 1; x < 204; x++)
    {
        
        printf("ASCII code %d is character %c\n", x, x);
    }

    return 0;
}