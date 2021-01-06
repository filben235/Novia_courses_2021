#include <string>
#include <math.h>

using namespace std;

//returns the chosen number from the fibonacci sequence
float fibonacci(int number) {
	float num1{ 0 }, num2{ 1 }, temp{ 0 };
	for (int i = 1; i < number; i++) {
		temp = num1 + num2;
		num1 = num2;
		num2 = temp;
	}
	return num1;
}

//returns the proper ending for specific numbers
string ending(int number) {
	string ending;
	if (11 <= number && number <= 13) {
		ending = "th";
	}
	else {
		int lastDigit = number % 10;
		switch (lastDigit) {
		case 1:
			ending = "st";
			break;
		case 2:
			ending = "nd";
			break;
		case 3:
			ending = "rd";
			break;
		default:
			ending = "th";
			break;
		}
	}
	return ending;
}