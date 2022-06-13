// WindowsLearnCpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdlib.h>
#include <time.h>

int getValueFromUser();
void printDouble(int value);

int Damage(int strength, int defense)
{
	int getRandom;

	getRandom = rand() % 10 + 0;

	return { getRandom + strength - defense } ;
}

int Input()
{
	int enemyHP{ 1 }, enemySTR{ 1 }, enemyDEF{ 0 };

	std::cout << "Input monster health, attack, def; and use spaces to seperate values = ";
	std::cin >> enemyHP >> enemySTR >> enemyDEF;

	return enemyHP;
}

int main()
{
	int playerHP{ 100 }, enemyHP{ Input() }, playerSTR{ 10 }, playerDEF{ 10 }, enemySTR{ 2 }, enemyDEF{ 2 };

	printDouble(getValueFromUser());

	std::cout << "hello world!\n" << Damage(playerSTR, enemySTR) << "\n" << Damage(enemySTR, playerDEF)
		<< "\n playerhp x 4: " << playerHP * 4;
	

	std::cout << "\n\nNow onto our next show";



	std::cout << "\nPlayerHP: " << playerHP << " | PlayerSTR: " << playerSTR << " | PlayerDEF: " << playerDEF
		<< "\nMonsterHP: " << enemyHP << " | MonsterSTR: " << enemySTR << " | MonsterDEF: " << enemyDEF << "\n\n";

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
