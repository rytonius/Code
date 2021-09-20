// Demonstrates using scanf() to input numeric and text data

#include <stdio.h>

int blankwhile();

char lname[81], fname[81];
int count, id_num;

int main()
{
    // prompt the user
    puts("Enter last name, first name, ID number seperated");
    puts("By spaces, then press Enter.");

    // Input the three data items

    count = scanf("%s%s%d", lname, fname, &id_num);

    // display the data

    printf("%d items entered: %s %s %d \n", count, fname, lname, id_num);

    puts("function blankwhile()");
    blankwhile();
    return 0;

}

int blankwhile()
{
    // declare a character array to hold input, and a pointer
    char input[81], *ptr;

    // display instructions

    puts("\nEnter text a line at a time, then press Enter.");
    puts("Enter a blank line when done. use CTRL + C to quit");

    // Loop until ctrl + c
    
    while(*(ptr = fgets(input, 81, stdin)) != NULL) printf("You entered %s\n", input);

    puts("Thank you and good-bye\n");
    

    return 0;
}
