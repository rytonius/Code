/*  Demonstrate passing a structure to a function. */

#include <stdio.h>

//  Declare and define a structure to hold the data

struct data {
    float amount;
    char fname[30];
    char lname[30];
} rec;


//  The function prototype.  The function has no return value,
//  and it takes a structure of type data as its one arguement.

void print_rec(struct data x);


int main()
{
    // Input the data from the keyboard.

    puts("Enter the donor's first and last names,\n");
    printf("seperated by a space: "); scanf("%s %s", rec.fname, rec.lname);

    printf("\nEnter the donation amount: ");
    scanf("%f", &rec.amount);

    //  Call the display function.
    print_rec( rec );
    
    return 0;
}

void print_rec(struct data x)
{
    printf("\nDonor %s %s gave $%.2f.\n", x.fname, x.lname, x.amount);
}

