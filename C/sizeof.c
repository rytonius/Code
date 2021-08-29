/* Program to tell the size of the C variable type in bytes */
#include <stdio.h>

int main()
{
    printf( "\nA char is            %lu bytes" , sizeof( char ));
    printf( "\nA int is             %lu bytes" , sizeof( int ));
    printf( "\nA short is           %lu bytes" , sizeof( short ));
    printf( "\nA long is            %lu bytes" , sizeof( long ));
    printf( "\nAn unsigned char is  %lu bytes" , sizeof( unsigned char ));
    printf( "\nAn unsigned int is   %lu bytes" , sizeof( unsigned int ));
    printf( "\nAn unsigned short is %lu bytes" , sizeof( unsigned short ));
    printf( "\nAn unsigned long is  %lu bytes" , sizeof( unsigned long ));
    printf( "\nA float is           %lu bytes" , sizeof( float ));
    printf( "\nA double is          %lu bytes" , sizeof( double ));
    printf( "\n");
    int ch;

    for( ch = 75 ; ch <= 100; ch++ ) {
        printf("ASCII value = %d, Character = %c\n", ch , ch );
    }

    printf( "\n");
    printf ("Integers: %i %u \n", -3456, 3456);
    printf ("Characters: %c %c \n", 'z', 80);
    printf ("Decimals: %d %ld\n", 1997, 32000L);
    printf ("Some different radices: %d %x %o %#x %#o \n", 100, 100, 100, 100, 100);
    printf ("floats: %4.2f %+.0e %E \n", 3.14159, 3.14159, 3.14159);
    printf ("Preceding with empty spaces: %10d \n", 1997);
    printf ("Preceding with zeros: %010d \n", 1997);
    printf ("Width: %*d \n", 15, 140);
    printf ("%s \n", "Educative");
    

    printf( "\n\nEnd of Script\n" );


    return 0;
}

/*
https://www.w3resource.com/c-programming/c-printf-statement.php

Escape sequence 	Action
\n 	prints a new line
\b 	backs up one character
\t 	moves the output position to the next tab stop
\\ 	prints a backslash
\" 	prints a double quote
\' 	prints a single quote 

Parameter 	Meaning
%d 	Print an integer number printed in decimal (preceded by a minus sign if the number is negative).
%f 	Print a floating point number ( in the form dddd.dddddd).
%E 	Print a floating point number ( in scientific notation: d.dddEddd).
%g 	Print a floating point number (either as f or E, depending on value and precision).
%x 	Print an integer number in hexadecimal with lower case letters.
%X 	Print an integer number printed in hexadecimal with upper case letters.
%c 	Print a character.
%s 	Print a string.

*/