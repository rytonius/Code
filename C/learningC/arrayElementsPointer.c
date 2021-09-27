/*  Demonstrates stepping through an array of structures
    using point notation */

#include <stdio.h>

#define MAX 4

// define a structure, then declare and initialize
// and array of 4 structures.
struct part {
    int number;
    char name[10];
} data[MAX] = { 1, "Smith",
                2, "Jones",
                3, "Adams",
                4, "Wilson"
                };

// Declare a pointer to type part, and a counter variable.

struct part *p_part;
int count;                

int main()
{
    // Initialize the pointer to the first array element.
    p_part = data;

    // Loop through teh array, incrementing the pointer
    // with each iteration
    puts("print pointer");
    for (count = 0; count < MAX; count++)
    {
        printf("At address %d: %d %s\n", p_part, p_part->number, p_part->name);
        p_part++;
    };
    puts("prints non pointer");
    for (count = 0; count < MAX; count++)
    {
        printf("At address %d: %d %s\n", &data[count], data[count].number, data[count].name);
        
    };
    
    return 0;
}