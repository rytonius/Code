#include <stdio.h>

int radius, area;
int taste();

int main(void) 
{
// lesson 1
    printf( "Enter radius (i.e. 10): ");
    scanf( "%d", &radius );
    area = (int) (3.14159 * radius * radius);
    printf("%d\n", radius);
    printf( "\n\nArea = %d\n", area );

    int x, y;

    for ( x= 0; x < 10; x++, printf( "\n"))
        for (y = 0; y < 10; y++ )
            printf("X");

    int tast;
    tast = taste();

    printf("\ntaste = %d\n", tast);

    printf("\n Hello,\
    world\n");

    return 0;


}

int taste(){
    int test;

    test = 10;

    return test;
}