/* Demonstrates unary operator prefix and postfix modes */

/* Description */
#include <stdio.h>

int a, b;

int main(void)
{
    /* set a and b both equal to 5 */

    a = b = 5;

    // print them, decrementing each time.
    // use prefix mode for b, postfix mode for a

    printf("\nPost\tPre");
    printf("\n%d\t%d", a--, --b);
    printf("\n%d\t%d", a--, --b);
    printf("\n%d\t%d", a--, --b);
    printf("\n%d\t%d", a--, --b);
    printf("\n%d\t%d\n", a--, --b);

    return 0;
}