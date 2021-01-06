#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <cmath>


float area(double radius) {
	return M_PI * (radius * radius);
}

float circumference(double radius) {
	return (2 * M_PI) * radius;
}

int main()
{
	const double radius{ 2.5 };
	
	std::cout << "Area: " << area(radius) << "\nCircumference: " << circumference(radius) << std::endl;
	system("pause");
	return 0;
}