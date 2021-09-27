/* how switch case works */

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    int reply;
    char input[40];

    while(1)
    {
        puts("\nEnter a value between 1 and 10, 0 to exit: ");
        scanf("%d", &reply);
        

        switch (reply){
            case 0: exit(0); // exit(0) ends the program homy
            // can be useful if your looking for various strings
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            {
                puts("You entered 5 or below.\n");
                break;
            }
            case 6 ... 10: // with int you can do ... for range
            {
                puts("You entered 6 or higher.\n");
                break;
            }
            default: puts("between 1 or 10 you loser!\n");
        } // end of teh switch

        puts("\n Input the desired system command (ls or dir for example)");
        scanf("%s", input);
        // system if ran on linux just sends commands to terminal
        system(input);
    }// end of da while

    return 0;
}