/* Demonstrates nested while statements */

#include <stdio.h>

int array[5];
int get_menu_choice(void);

int main() 
{
    int ctr = 0,
        nbr;

    printf("This program prompts you to enter 5 number\n");
    printf("Each number should be from 1 to 10\n");
    
    while( ctr < 5)
    {
        nbr = 0;
        while(nbr < 1 || nbr > 10) 
        {
            printf("\nEnter number %d of 5: ", ctr + 1);
            scanf("%d", &nbr);
        }

        array[ctr] = nbr;
        ctr++;
    }

    for (ctr = 0; ctr < 5; ctr++)
        printf("Value %d is %d\n", ctr + 1, array[ctr]);

    int choice;

    choice = get_menu_choice();
    printf("You chose Menu Option %d\n", choice);

    return 0;
}

int get_menu_choice(void)
{
    int selection = 0;

    do
    {
        printf("\n\
        \n1 - Add a Record\
        \n2 - Change a Record\
        \n3 - Delete a record\
        \n4 - Quit\
        \n\nEnter a selection: ");
        scanf("%d", &selection );

        
    } while ( selection < 1 || selection > 4);
    return selection;
}

