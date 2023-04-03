#include <iostream>
#include <cstdint> // for std::int64_t
#include <cassert> // for assert
#include <algorithm>
#include <cmath>


// note: exp must be non-negative
std::int64_t powint(int base, int exp)
{
	assert(exp >= 0 && "powint: exp parameter has negative value");

	std::int64_t result{ 1 };
	while (exp)
	{
		if (exp & 1)
			result *= base;
		exp >>= 1;
		base *= base;
	}

	return result;
}

int conditional_operator(int x, int y) {
	
	std::cout << ((x > y) ? x : y) << std::endl;
	// if (x > y) return x else return y
	return (x > y) ? x : y;
}

// return true if the difference between a and b is within epsilon percent of the larger of a and b
bool approximatelyEqualRel(double a, double b, double relEpsilon)
{
	return (std::abs(a - b) <= (std::max(std::abs(a), std::abs(b)) * relEpsilon));
}

bool approximatelyEqualAbsRel(double a, double b, double absEpsilon, double relEpsilon)
{
	// Check if the numbers are really close -- needed when comparing numbers near zero.
	double diff{ std::abs(a - b) };
	if (diff <= absEpsilon)
		return true;

	// Otherwise fall back to Knuth's algorithm
	return (diff <= (std::max(std::abs(a), std::abs(b)) * relEpsilon));
}

int main()
{
	std::cout << powint(7, 12); // 7 to the 12th power
	std::cout << "\n\n";

	std::cout << conditional_operator(5, 6);

	std::cout << "\n\n";

	constexpr bool inBigClassroom{ false };
	// since inBigClass is false you will get 20.  If it was true then 30.
	constexpr int classSize{ inBigClassroom ? 30 : 20 };
	std::cout << "The class size is: " << classSize << '\n';

	// a is really close to 1.0, but has rounding errors
	//bool approximatelyEqualAbsRel(double a, double b, double absEpsilon, double relEpsilon)
	double a{ 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 };

	std::cout << approximatelyEqualRel(a, 1.0, 1e-8) << '\n';     // compare "almost 1.0" to 1.0
	std::cout << approximatelyEqualRel(a - 1.0, 0.0, 1e-8) << '\n'; // compare "almost 0.0" to 0.0

	std::cout << approximatelyEqualAbsRel(a, 1.0, 1e-12, 1e-8) << '\n'; // compare "almost 1.0" to 1.0
	std::cout << approximatelyEqualAbsRel(a - 1.0, 0.0, 1e-12, 1e-8) << '\n'; // compare "almost 0.0" to 0.0

	return 0;
}