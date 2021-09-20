/* Program Name: week2.c
    program to enter information for up to 100
    people.  The program prints a report based
    on the numbers entered
                                             */
// included headers
#include <stdio.h>
#include <stdlib.h>

// define constants
#define MAX     100
#define YES     1
#define NO      0

// Variables
struct record {
    char fname[15+1];       // first name + null
    char lname[20+1];       // last name + NULL
    char phone[9+1];        // phone number + NULL
    long income;            // incomes
    int month, day, year;   // birthday 
} list[MAX];   // declare actual structure

int last_entry = 0;         // total number of entries;

// function prototypes

void get_data(void);
void display_report(void);
int continue_function(void);

int main(void)
{
    int cont = YES;
    int ch;

    while (cont == YES)
    {
        puts("\n");
        puts("\tMenu============");
        puts("\tn1.\tEnter names");
        puts("\tn2.\tPrint report");
        puts("\t3.\tQuit");
        printf("\nEnter Selection: ");

        ch = getchar();

        fflush(stdin); // remove extra characters from keyboard buffer

        switch(ch)
        {
            case '1': get_data(); break;
            case '2': display_report(); break;
            case '3': printf("\n\nThank you for using this program!\n");
                        cont = NO;
                        break;
            default:  printf("\n\nInvalid choice, Please select 1 to 3");
                        break;
        }
        
    }

    return 0;
    
}

/*  Function:   get_data()
    Purpose:    This function gets the data from the user. It 
                continues to get data until either 100 people are
                entered, or the user chooses not to continue.
    Notes:      This allows 0/0/0 to be entered for birthdates in
                case the user is unsure.  It also allows for 31 days
                in each month.
                                                            */
void get_data(void)
{
    int cont;

    for ( cont = YES; last_entry < MAX && cont == YES; last_entry++)
    {
        fflush(stdin);
        printf("\n\nEnter information for Person %d.", last_entry+1);

        printf("\n\nEnter first name: ");
        fgets(list[last_entry].fname, 40, stdin);

        printf("\nEnter last name: ");        
        fgets(list[last_entry].lname, 40, stdin);

        printf("\nEnter phone in 123-4567 format: ");
        fgets(list[last_entry].phone, 9, stdin);

        printf("\nEnter Yearly Income (whole dollars): ");
        scanf("%ld", &list[last_entry].income);

        printf("\nEnter Birthday: ");

        do{
            printf("\n\tMonth (0-12): ");
            scanf("%d", &list[last_entry].month);
        } while ( list[last_entry].month < 0 || 
                  list[last_entry].month > 12 );
        
        printf("\nmonth = %d\n", list[last_entry].month);

        if(list[last_entry].month == 1    ||
                list[last_entry].month == 3  ||
                list[last_entry].month == 5  ||
                list[last_entry].month == 7  ||
                list[last_entry].month == 8  ||
                list[last_entry].month == 10 ||
                list[last_entry].month == 12   )
            {
            do{
            printf("\n\tDay (0-31): ");
            scanf("%d", &list[last_entry].day);
            } while ( list[last_entry].day < 0 || 
                  list[last_entry].day > 31 );
        }

        else if(list[last_entry].month == 4 ||
                list[last_entry].month == 6 ||
                list[last_entry].month == 9 ||
                list[last_entry].month == 11)
            {
            do{
            printf("\n\tDay (0-30): ");
            scanf("%d", &list[last_entry].day);
            } while ( list[last_entry].day < 0 || 
                  list[last_entry].day > 30 );
        }
        else {
            do{
            printf("\n\tDay (0-29): ");
            scanf("%d", &list[last_entry].day);
            } while ( list[last_entry].day < 0 || 
                  list[last_entry].day > 29 );
        }

        do{
            printf("\n\tYear (1900-2050): ");
            scanf("%d", &list[last_entry].year);
            } while ( list[last_entry].year < 1900 || 
                  list[last_entry].year > 2050 );

        cont = continue_function();
    }

    if( last_entry == MAX) puts("\n\nMaximum Number of Names has been entered!");

}

/* Function:    display_report()
    Purpose:    This function displays a report to the screen
      Notes:    More information could be displayed.
                Change stdout to stdprn to Print report
                                                            */
void display_report()
{
    long    month_total = 0,
            grand_total = 0;
    int x, y;

    fprintf(stdout, "\n\n");    // skip a few lines
    fprintf(stdout,"\n\tReport");
    fprintf(stdout,"\n\t======");

    for( x = 0; x <= 12; x++) // for each month, including 0
    {
        month_total = 0;
        for( y= 0; y < last_entry; y++)
        {
            if(list[y].month == x)
            {
                fprintf(stdout, "\n\t%s %s %s %ld", list[y].fname,
                                                list[y].lname,
                                                list[y].phone,
                                                list[y].income);
                month_total += list[y].income;
            }
        }
        fprintf(stdout, "\nTotal for month %d is %ld",x,month_total);
        grand_total += month_total;
    }   
    fprintf(stdout, "\n\nReport totals:");
    fprintf(stdout, "\nTotal Income is %ld", grand_total);

    fprintf(stdout, "\n\n* * * End of Report * * *");
}

/* Function:        Continue_function()
    Purpose:        This function asks the user if they 
                    wish to continue.
    Returns:        Yes - if user wishes to continue
                    No - if user wishes to quit
                                                        */
int continue_function(void){
    int ch;

    printf("\n\nDo you wish to continue? (Y)es/(N)o: ");
    fflush(stdin);

    ch = getchar();

    while( ch != 'n' && ch != 'N' && ch != 'y' && ch != 'Y')
    {
        printf("\n%c is invalid!", ch);
        printf("\n\nPlease enter \'N\' to Quit or \'Y\' to continue: ");

        fflush(stdin);
        ch = getchar();
    }
    fflush(stdin);

    if(ch == 'n' || ch == 'N')
        return(NO);
    else
        return(YES);
}