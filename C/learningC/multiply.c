/* Program to Calculate Numbers */
#include <stdio.h>

int a,b,c,d,e;

int product(int x, int y);
int sum(int x, int y);
int subtract(int x, int y);
int divide(int x, int y);
int remain( int x, int y);

int main(void)
{
    /* Get the first number */
    printf("Enter a number between 1 and 100: ");
    scanf("%d", &a);
    /* Get the second number */
    printf("Enter a second number between 1 and 100: ");
    scanf("%d", &b);

    /* now to multiply */
    c = product(a, b);
    printf( "%d times %d = %d\n", a, b, c);
    // add
    c = sum(a, b);
    printf( "%d plus %d = %d\n", a, b, c);
    // sub
    c = subtract(a, b);
    printf( "%d minus %d = %d\n", a, b, c);
    // dive and rem
    d = divide(a, b);
    e = remain(a, b);
    printf( "%d divide %d = %d r:%d\n", a, b, d, e);

    return 0;
}

/* function returns the product of the two values provided */
int product(int x, int y) { return (x * y); }

int sum(int x, int y) { return (x + y); }

int subtract(int x, int y) { return (x - y); }

int divide(int x, int y) { return (x / y);}

int remain( int x, int y) { return (x % y);}

    