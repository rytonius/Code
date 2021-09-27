/* Illustrates variable scopes and static */

#include <stdio.h>
//everybuddy can use x
int x = 999;
int z;
int print_value(int y);
void func1(void);
int main()
{
    // only a function with extern can use this y here
    int z = 888;
    //may use variable x
    printf("%d\n", x);
    printf("%d",print_value(z));
    int y = 777;
    puts("static stuff");
    int count;
    for (count = 0;count < 20; count++){
        printf("At iteration %d: ", count);
        func1();
    }

    //define a variable local to main().

    int localvariable = 0;

    printf("\n Outside the block, localvariable = %d", localvariable);

    // start a block
    {
        // define a variable local to the block

        int localvariable = 999;
        printf("\n within the block, localvariable = %d", localvariable);
    }
    printf("\n Outside the block again, localvariable = %d\n", localvariable);

    puts("goto statement");

    int n;
start:

    puts("Enter an umber between 0 and 10: ");
    scanf("%d", &n);

    if (n < 0 || n > 10)
        goto start;
    else if (n ==0)
        goto location0;
    else if (n == 1)
        goto location1;
    else 
        goto location2;

location0:
    puts("You entered 0\n");
    goto end;

location1:
    puts("You entered 1.\n");
    goto end;
location2:
    puts("You enterted 2 - 10\n");

end:
    return 0;


    return 0;
}

int print_value(int z)
{
    /*  
        extern variable is defined outside of any function.  this means
        This means outside of main() as well because main() is a function, too
        extern int y;
    */
    
    return z;
}

void func1(void){
    // x will increase since it's static; int y will initialize as 0 every time
    static int x = 0;
    int y = 0;

    printf("x = %d, y = %d\n", x++, y++);
}