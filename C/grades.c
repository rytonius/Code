/* grades. c - Sample program with array */
/* Get 10 grades and then average them */

/* headers */
#include <stdio.h>

//define
#define MAX_GRADE 100
#define STUDENTS 10

//variables
int grades[STUDENTS]; //the array, limited by STUDENTS 
int idx, total = 0; // to get average

int main(void)
{
    for (idx=0; idx< STUDENTS; idx++)
    {
        printf( "Enter Person %d's grade: ", idx +1);
        scanf( "%d", &grades[idx]);

        while (grades[idx] > MAX_GRADE )
             {
                 printf("\nThe highest grade possible is %d", MAX_GRADE);
                 printf("\nEnter correct grade: ");
                 scanf("%d", &grades[idx]);

             }
        total += grades[idx];
    }

    printf("\n\nThe average score is %d\n", (total / STUDENTS));

    return 0;
}