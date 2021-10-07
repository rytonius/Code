#include <iostream>
#include <vector>
#include <string>

int main()
{
    std::cout << "Hello World!";

    // declaring variables:
    int a, b;
    int result;

  // process:
    a = 5;
    b = 2;
    a = a + 1;
    result = a - b;

  // print out the result:
    std::cout << result;
}

/*
Group	                Type names*	Notes on size / precision
Character types	        char	    Exactly one byte in size. At least 8 bits.
                        char16_t	Not smaller than char. At least 16 bits.
                        char32_t	Not smaller than char16_t. At least 32 bits.
                        wchar_t	    Can represent the largest supported character set.
Integer types (signed)	signed char	        Same size as char. At least 8 bits.
                        signed short int	Not smaller than char. At least 16 bits.
                        signed int	        Not smaller than short. At least 16 bits.
                        signed long int	    Not smaller than int. At least 32 bits.
                        signed long long int	Not smaller than long. At least 64 bits.
Integer types (unsigned)	unsigned char	(same size as their signed counterparts)
                            unsigned short int
                            unsigned int
                            unsigned long int
                            unsigned long long int
Floating-point types	float	
                        double	Precision not less than float
                        long double	Precision not less than double
Boolean type	    bool	
Void type	void	no storage
Null pointer	    decltype(nullptr)	
*/