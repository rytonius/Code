/* Description */
#include <stdio.h>

int x, y, z;

int main(void)
{
    // input the two values to be tested

    printf("\nInput an integer value for x and y seperate with /: ");
    scanf("%d/%d", &x, &y);
    printf("\nx: %d\ny: %d\n", x, y);

    // Test values and print result

    if (x == y) printf("x is equal to y\n");
    if (x > y) printf("x is greater than y\n");
    if (x < y) printf("x is less than y\n");

    if (x == y) 
        printf("2: x is equal to y\n");
    else
        if (x > y)
            printf("2: x is geater than y\n");
        else
            printf("2: x is less than y\n");
    // ? allows you to set a true or false answer to the solution, if true X if false y (or less or more)
    printf("\nz is now the bigger x or y: %d\n", (z = (x > y) ? x : y));
    int a= 5, b = 6, c = 5, d =1;

    x = a < b || a < c && c < d;
    printf("\nWithout parentheses the expression evaluates as %d", x);

    x = (a < b || a < c) && c < d;
    printf("\nWith parentheses the expression evaluates as %d\n", x);

    return 0;
}