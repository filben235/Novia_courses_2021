#include <iostream>
using std::cout;
using std::endl;

void SwapByValue(int iFirstValue, int iSecondValue)
{
	int iTempValue;
	iTempValue = iFirstValue;
	iFirstValue = iSecondValue;
	iSecondValue = iTempValue;	
}

void SwapByReference(int& riFirstValue, int& riSecondValue)
{
	int iTempValue;
	iTempValue = riFirstValue;
	riFirstValue = riSecondValue;	
	riSecondValue = iTempValue;
}

void SwapByPointer(int* piFirstValue, int* piSecondValue)
{
	int iTempValue;
	if (piFirstValue != nullptr && piSecondValue != nullptr) {
		iTempValue = *piFirstValue;
		*piFirstValue = *piSecondValue;
		*piSecondValue = iTempValue;
	}
}

void Square(int& riNumber)
{
	riNumber*=riNumber;
	// riNumber = riNumber*riNumber;
}

void main()
{
	int a = 1;
	int b = 2;

	cout << "** Before value swap ****" << endl;
	cout << "The value of a =" << a << endl;
	cout << "The value of b =" << b << endl;
	cout << "*************************" << endl;
	
	SwapByValue(a, b);

	cout << "** After value swap before reference swap****" << endl;
	cout << "The value of a =" << a << endl;
	cout << "The value of b =" << b << endl;
	cout << "*************************" << endl;
	
	SwapByReference(a, b);

	cout << "** After reference swap before pointer swap ****" << endl;
	cout << "The value of a =" << a << endl;
	cout << "The value of b =" << b << endl;
	cout << "*************************" << endl;

	SwapByPointer(&a, &b);

	cout << "** After pointer swap before square****" << endl;
	cout << "The value of a =" << a << endl;
	cout << "The value of b =" << b << endl;
	cout << "*************************" << endl;
	
	Square(b);

	cout << "** After square swap****" << endl;
	cout << "The value of a =" << a << endl;
	cout << "The value of b =" << b << endl;
	cout << "*************************" << endl;
	
}
