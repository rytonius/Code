#include<iostream>
#include<string>
#include<math.h>
#include<stdbool.h>

#include"primenumber.h"

bool IsPrimeNumber() {
	std::cout << "\nEnter a non decimal number to see if it is prime: ";
	float f{};
	f = floor(f);
	int x = f;

	std::cin >> x;

	std::cout << x << " was entered\n";
	return LoopInput(x);

}

bool LoopInput(int x)
{
	for (int y = 2; y <= x / 2; y++) {
		std::cout << std::left << "\nchecking " << x << " % " << y << " divided with remaining: " << std::right << (x / y) << "r" << (x % y);
		if (x % y == 0) return false;
	}

	return true;
}
