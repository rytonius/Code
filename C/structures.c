/* Demonstrates structures that contain other structures.
    Receives input for corner coordinates of a rectangle and
    calculates the area.  Asumes that the y coordinate of the
    lower-right corner is greater than the y coordinate of the
    upper-left corner, that the x coordinate of the lower- 
    right corner is greater than the x coordinate of the upper-
    left corner, and that all coordinates are positive         */

#include <stdio.h>

int arrayStructure();

int length, width;
long area;

struct coord{
    int x;
    int y;
};

struct rectangle{
    struct coord topleft;
    struct coord bottomrt;
}mybox;

// Declare an array of structures
struct entry {
    char fname[20];
    char lname[20];
    char phone[10];
};

struct entry list[4];

int i;

int main(void)
{
    // Input the coordinates

    puts("\nEnter the top left x coordinate: ");
    scanf("%d", &mybox.topleft.x);

    puts("\nEnter the top left y coordinate: ");
    scanf("%d", &mybox.topleft.y);

    puts("\nEnter the bottom right x coordiante: ");
    scanf("%d", &mybox.bottomrt.x);

    puts("\nEnter the bottom right y coordinate: ");
    scanf("%d", &mybox.bottomrt.y);

    // Calculate the length and width 
    width = mybox.bottomrt.x - mybox.topleft.x;
    length = mybox.bottomrt.y - mybox.topleft.y;

    // calculates and display the area
    area = width * length;
    printf("\nThe area is %ld units.\n",area);

    puts("arrayStructure()");
    

    // loop to input data for four people
    for (i = 0; i < 1; i++) {
        puts("\n Enter first name: ");
        scanf("%s", &list[i].fname);
        puts("Enter last name: ");
        scanf("%s", &list[i].lname);
        puts("Enter phone number 5554443333");
        scanf("%s", &list[i].phone);
    }

    // print two blank lines

    puts("\n");

    // loop to display data

    for (i = 0; i< 1; i++){
        printf("Name: %s %s", list[i].fname, list[i].lname);
        printf("\t\tPhone: %s\n", list[i].phone);
    }


    return 0;
}

