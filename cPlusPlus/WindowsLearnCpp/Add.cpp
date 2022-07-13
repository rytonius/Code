#include <iostream>
#include "add.h"
int getValueFromUser()
{
	std::cout << "Enter an integer: ";
	int input{};
	std::cin >> input;

	return input;
}

void printDouble(int value)
{
	std::cout << value << " doubled is: " << value * 2 << '\n';
}

int subtract(int x, int y) {
	return x - y;
}

int add(int x, int y) {
	return x + y;
};
int multi(int x, int y) {
	return x * y;
}
float divide(float x, float y) {
	
	return (x / y);
};