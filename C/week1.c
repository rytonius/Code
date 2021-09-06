/* ------------------------------------------------------------\
*   Program Name:   week1.c                                     |
*   Purpose:        Program to enter the ages and incomes of up |
*                   to 100 people.  The program prints a report |
*                   based on the numbers entered                |
*  ------------------------------------------------------------*/

// Included Files
#include <stdio.h>

// Defined Constants
#define MAX     100
#define YES     1
#define NO      0

// Variables
long    income[MAX];                        // to hold incomes and year dates
int     yinput[MAX];
int     month[MAX], day[MAX], year[MAX];    // to hold birthdays
int     x, y, ctr;                          // for counters
int     cont;                               // for program control
long    month_total, grand_total, year_average, grand_ytotal;           // for totals

// Function Prototypes
void main(void);
int display_instructions(void);
void get_data(void);
void display_report(void);
int continue_function(void);

// Start of Program

void main(void)
{
    cont = display_instructions();

    if ( cont == YES ){
        get_data();
        display_report();
    } else printf( "\nProgram Aborted by User!\n\n)");

}

/* ------------------------------------------------------------\
*   Function:       Display_instructions()                      |
*   Purpose:        This function displays information on how to|
*                   use this program and asks the user to enter |
*                   0 to quit, or 1 to continue                 |
*   Returns:        No - if the user enters 0                   |
*                   Yes- if the user enters any number other    |
*                        than 0                                 |                                  
*  ------------------------------------------------------------*/

int display_instructions(void)
{
    printf("\n\n\n");
    printf("This program enables you to enter up to 99 peoples\'s\
    \nincomes and brithdays.  It then prints the incomes by\
    \nmonth along with the overall income and overall average.");
    printf("\n");

    cont = continue_function();

    return(cont);
}

/* ------------------------------------------------------------\
*   Function:       get_data()                                  |
*   Purpose:        This function gets the data from the user.  |
*                   It continues to get data until either 100   |
*                   people are entered, or until the user enters|
*                   0 for the month.                            |
*   Returns:        nothing                                     |
*   Notes:          This allows 0/0/0 to be entered for birth-  |
*                   days in case the user is unsure. It also    |
*                   allows for 31 days in each month.           |
*  ------------------------------------------------------------*/

void get_data(void)
{
    for ( cont = YES, ctr = 0; ctr < MAX && cont == YES; ctr++)
    {
        printf("\nEnter information for Person %d ", ctr+1);
        printf("\n\tEnter Birthday:");

        do {
            printf("\n\tmonth (0 - 12): ");
            scanf("%d", &month[ctr]);
        } while (month[ctr] < 0 || month[ctr] > 12);

        do {
            printf("\n\tDay (0 - 31): ");
            scanf("%d", &day[ctr]);
        } while (day[ctr] < 0 || day[ctr] > 31);

        do {
            printf("\n\tyear (0 - 2021): ");
            scanf("%d", &year[ctr]);
            yinput[ctr] = year[ctr];
        } while (year[ctr] < 0 || day[ctr] > 2021);

        printf("\nEnter Yearly Income (whole dollars): ");
        scanf("%ld", &income[ctr]);
        printf("year: %d\n", year[ctr]);
        printf("yinput: %d\n", yinput[ctr]);
        cont = continue_function();       
    }
    /* ctr equals the number of people that were entered. */
}

/* -------------------------------------------------------------\
*   Function:       Display_report()                             |
*   Purpose:        This function displays a report to the screen|
*   Returns:        nothing                                      |
*   Note:           More information could be printed.           |
*  ------------------------------------------------------------*/

void display_report()
{
    grand_total = 0;
    printf("\n\n\n"); // skip a few lines
    printf("\n\t\tSALARY SUMMARY");
    printf("\n\t\t==============");

    for( x= 0; x <= 12; x++) 
    {
        month_total = 0;
        for( y= 0; y < ctr; y++) {
            if( month[y] == x ) month_total += income[y];
        }

    printf("\nTotal for month %d is %ld", x, month_total);
    grand_total += month_total;
    }

    for (x = 0; x <= 2021; x++)
    {
        year_average = 0;
        
        for( y=0; y < ctr; y++) 
        {
            if( yinput[y] == x) year_average += yinput[y];
        }
        
        if (year_average != 0) 
        {
            printf("\nincome in year %d is %ld", x, income[ctr]);    
        }
        
        grand_ytotal += year_average;    
    }


    printf("\n\nReport totals: ");
    printf("\nTotal Income is %ld", grand_total);
    printf("\nAverage Income is %ld", grand_total/ctr);
    printf("\nyear average = %ld\n", grand_ytotal/ctr);

    printf("\n\n* * * End of report * * * \n\n\n");
}

/* -------------------------------------------------------------\
*   Function:       Continue_function()                          |
*   Purpose:        This function asks the user if they wish to  |
*                   continue.                                    |
*   Returns:        YES - if user wishes to continue             |
*                   NO  - if user wishes to quit                 |
*  ------------------------------------------------------------*/

int continue_function( void )
{
    printf("\n[======{;;;;;;;;;;;::::::::::::::::::::::>");
    printf("\n\nDo you wish to continue? (0=NO/1=YES) : ");
    scanf("%d", &x);

    while( x < 0 || x > 1)
    {
        printf("\n%d is invalid!", x);
        printf("\nPlease enter 0 to Quit or 1 to Continue: ");
        scanf("%d", &x);
    }
    if(x == 0) return(NO); else return(YES);
}