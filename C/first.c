#include <stdio.h>

int radius, area;
int tencount();
int printTenX();

int main(void) 
{
// lesson 1
    printf( "Enter radius (i.e. 10): ");
    scanf( "%d", &radius );
    area = (int) (3.14159 * radius * radius);
    printf("%d\n", radius);
    printf( "\n\nArea = %d\n", area );

    int x, y, z;

    for ( x= 0; x < 10; x++, printf( "\n"))
        for (y = 0; y < 10; y++ )
            printf("X");

    int tast;
    tast = tencount();

    printf("\ntencount = %d\n", tast);

    printf("\n Hello,\
    world\n");
    z=0;
    do {
        puts("run printTenX?: 1=yes anything else this lasts forever ");
        scanf("%d", &z);
    } while (z != 1);
    
    

    
    printTenX();
    return 0;


}

int tencount(){
    int test;

    test = 10;

    return test;
}

int printTenX(){
    int x;
    for (x=0;x < 10; x++) printf("\nx: %d" , x); 
    puts("");
}

/* 
\a bell
\b backspace
\n newline
\t tab
\\ backslash
\? question mark
\' single quotation

int printf()
n the character n
\n newline
\" the double quotation
" start or end of string "

*/