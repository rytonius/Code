/* Passing an array to a function. */

#include <stdio.h>
#include <stdlib.h>

#define MAX 10

int array[MAX], count;

int largest(int x[], int y);

int main(void)
{
    int random = rand();
    // Input MAX values from the keyboard

    for (count = 1; count <= MAX; count++){
        random = rand();
        printf("Enter an integer value %d/%d: %d \n", count, MAX, random);
        array[count] = random;
        //scanf("%d", &array[count]);
    }
    // Call the function and display the return value
    printf("\n\nLargest value = %d\n", largest(array, MAX));

    return 0;
}

int largest(int x[], int y)
{
    int count, biggest = -12000;

    for (count = 1; count <= y; count++){
        if (x[count] > biggest) biggest = x[count];
    }

    return biggest;
}