// WindowsLearnCpp.cpp : This file contains the 'main' function. Program execution begins and ends there.

#include <iostream>
#include <stdlib.h>
#include <time.h>

//double quotes has compiler search though current working directory
// you can include other directories with file paths ie "folder/path/myheaders.h"
#include "add.h"

#define PRINT_JOE

int getValueFromUser();
void printDouble(int value);

int Damage(int strength, int defense)
{
	int getRandom;
	std::cout << "\ntaking strenght and subtracting defense then using a random gen: " << strength << "\t" << defense;
	
	getRandom = rand() % 10 + 0;

	return { getRandom + strength - defense } ;
}

int Input()
{
	int enemyHP{ 1 }, enemySTR{ 1 }, enemyDEF{ 0 };

	std::cout << "\nInput monster health, attack, def; and use spaces to seperate values = ";
	std::cin >> enemyHP >> enemySTR >> enemyDEF;

	return enemyHP;
}

void Conditional_Compliation() {
#ifdef PRINT_JOE
	std::cout << "\n Joe\n";
#endif

#ifdef PRINT_BOB
	std::cout << "\nBOB\n";
#endif

#ifndef DOESNTEXIST
	std::cout << "\nThis prints becaues ifndef is if a condition doesn't exist";
#endif

/*
In place of #ifdef PRINT_BOB and #ifndef PRINT_BOB, you’ll also see 
#if defined(PRINT_BOB) and #if !defined(PRINT_BOB).These do the same, but use a slightly more C++ - style syntax.
*/

#if 0 // Don't compile anything starting here
	std::cout << "Bob\n";
	/* Some
	 * multi-line
	 * comment here
	 */
	std::cout << "Steve\n";
#endif // until this point
}

void Static_Cast_Example(int x) {
	//https://www.learncpp.com/cpp-tutorial/introduction-to-type-conversion-and-static_cast/
	std::cout << x << std::endl;
	char ch{ 97 }; //97 is ASCII code for 'a'
	std::cout << ch << " has a value of " << static_cast<int>(ch) << '\n';
	unsigned int u{ 5u }; // 5u means the number 5 as an unsigned int
	int s{ static_cast<int>(u) }; // return value of variable u as an int

	int z{ 7 };
	int y{ 4 };

	// you can divide ints by casting to a double or float
	std::cout << "int / int = " << z / y << '\n';
	std::cout << "double / int = " << static_cast<double>(z) / y << '\n';
	std::cout << "int / double = " << z / static_cast<double>(y) << '\n';
	std::cout << "double / double = " << static_cast<double>(z) / static_cast<double>(y) << '\n';

	std::cout << s << '\n';
}

void ASCII(char x) {
	std::cout << "\nYou entered: " << static_cast<char>(x) << " which has an ASCII code of: " << static_cast<int>(x);
}

int main()
{
	/*Key insight

	Whenever you see C++ syntax (excluding the preprocessor) that makes use of angled brackets (<>), 
	the thing between the angled brackets will most likely be a type.
	This is typically how C++ deals with concepts that need a parameterizable type.  */ 
	Static_Cast_Example(static_cast<int>(5.5));

	std::cout << "Enter a single character: ";
	char singlechar{};
	std::cin >> singlechar;
	ASCII(static_cast<char>(singlechar));

	int playerHP{ 100 }, enemyHP{ Input() }, playerSTR{ 10 }, playerDEF{ 10 }, enemySTR{ 2 }, enemyDEF{ 2 };

	printDouble(getValueFromUser());

	std::cout << "hello world!\n" << Damage(playerSTR, enemySTR) << "\n" << Damage(enemySTR, playerDEF)
		<< "\n playerhp x 4: " << playerHP * 4;

	std::cout << "5 subtracted from 4 =" << subtract(4, 5);

	

	std::cout << "\n\nNow onto our next show";



	std::cout << "\nPlayerHP: " << playerHP << " | PlayerSTR: " << playerSTR << " | PlayerDEF: " << playerDEF
		<< "\nMonsterHP: " << enemyHP << " | MonsterSTR: " << enemySTR << " | MonsterDEF: " << enemyDEF << "\n\n";

	std::cout << "\n\n";
	Conditional_Compliation();
	return 0;

}



// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
