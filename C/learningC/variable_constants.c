/* Demonstrates variables and constants */
#include <stdio.h>

// Define a constant to convert from pounds to grams
#define GRAMS_PER_POUND 454

// define a constant for the start of the next century
const int TARGET_YEAR = 2021;

// declare the needed variables
long weight_in_grams, weight_in_pounds;
int year_of_birth, age_in_2010;

int main(void)
{
    // input data from user

    printf(" Enter your weight in pounds: ");
    scanf("%d", &weight_in_pounds);
    printf("Enter your year of birth: ");
    scanf("%d", &year_of_birth);

    // perform conversions

    weight_in_grams = weight_in_pounds * GRAMS_PER_POUND;
    age_in_2010 = TARGET_YEAR - year_of_birth;

    // display results on the screen

    printf("\nYour weight in grams = %1ld", weight_in_grams);
    printf("\n In 2021 you will be %d years old\n", age_in_2010);

    return 0;
}