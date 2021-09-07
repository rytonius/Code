#include <stdio.h>

int ArrayPointer(void);
int PointerNotation(void);
int BasicPointer(void);

#define MAX 10

int main(void)
{
    puts("\nbasicpointer()\n");
    BasicPointer();
    puts("\nArrayPointer()\n");
    ArrayPointer();
    puts("\nPointerNotation()\n");
    PointerNotation();
    return 0;
}

/* Demonstrates basic pointer use. */
int BasicPointer(void)
{
    // declare functions
 
    // declare and initialize an int variable

    int var = 1;
    int vint =12252;
    char vchar = 90;
    float vfloat = 1200.156004;


    // declare pointer to int

    int *ptr;
    int *p_vint;
    char *p_vchar;
    float *p_vfloat;
    // Initialize ptr to point to var
    ptr = &var;

    // Access var directly and indirectly

    printf("\nDirect access, var = %d", var);
    printf("\nIndirect access, var = %d", *ptr);

    // display the address of var two ways

    printf("\n\nThe address of var = %d", &var);
    printf("\nThe address of ptr = %d\n", ptr);

    p_vint = &vint;
    p_vchar = &vchar;
    p_vfloat = &vfloat;

    
    printf("\n\nvint: %d and address %d", vint,p_vint);
    printf("\nvchar: %c and address %d", vchar, p_vchar);
    printf("\np_vfloat %.4f and address %d", vfloat, p_vfloat);
    printf("\n\n");

    return 0;
}

int ArrayPointer(void){
    //Demonstrations array element address

    int i[10], x;
    float f[10];
    double d[10];

    printf("\t\tInteger\t\tFloat\t\tDouble");
    puts("\n===============================================================================");
    
    
    // print addresses of each array element.

    for (x=0; x< 10; x++)
        printf("Element %d: \t%ld\t\t%ld\t\t%ld\n", x, &i[x], &f[x], &d[x]);

    puts("===============================================================================");

    return 0;
}

int PointerNotation(void)
{
    // demonstrate using pointer arithmetic to access
    
    // declare and initialize an integer array.
    int i_array[MAX] = {0,1,2,3,4,5,6,7,8,9};

    // Declare a pointer to int and an int variable

    int *i_ptr, count;

    // Declare and initialize a float array.

    float f_array[MAX] = { .0, .1, .2, .3, .4, .5, .6, .7, .8, .9};

    // declare a pointer to float

    float *f_ptr;

    // initialize the pointers

    i_ptr = i_array;
    f_ptr = f_array;

    for (count = 0; count < MAX; count++)
        printf("%d\t%f\n", *i_ptr, *f_ptr++);


    return 0;
}