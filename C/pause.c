/* Description */

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void sleep( int nbr_seconds );

int main(void)
{
    int x;
    int wait;

    puts("enter wait times: ");
    scanf("%d", &wait);

    printf("Delay for %d seconds\n", wait);
    printf(">");

    for (x=1; x <= wait; x++){
        printf("."); // print a dot
        fflush(stdout); // force dot to print on buffered machines
        sleep( (int) 1); // pause for 1 second
    }
    printf( "Done!\n)");

    return 0;
}

// pause for a specific time
void sleep ( int nbr_seconds )
{
    
    clock_t goal;

    goal = ( nbr_seconds * CLOCKS_PER_SEC ) + clock();

    while ( goal > clock() )
    {
        ; 
    }
}
