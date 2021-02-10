// Pointer operators & and *.
#include <iostream>
using namespace std;

#include "TemperaturSelector.h"
#include "ExitReaons.h"


int main() 
{
    float innerTemperatur{ 21.3f }; // initialize the variabel with 7
    float outerTemperatur{ -7.2f };
    float* pTheSelectedTemperatur = nullptr; // initialize the pointer to null, nothing selected


    cout << "The address of innerTemperatur is " << &innerTemperatur
        << "\nThe value of innerTemperatur is " << innerTemperatur << endl;

    cout << "The address of outerTemperatur is " << &outerTemperatur
        << "\nThe value of outerTemperatur is " << outerTemperatur << endl;

	cout << endl;
	unsigned int selectedOption = 0;

	selectedOption = SelectTemperaturToDisplay();
	if (g_ExitReason == NormalExitReason) // we have a good to go clearens
	{
		// Todo
	}
	else
		cout << "We had a problem, exitReason=" << g_ExitReason <<"!\n";

	return g_ExitReason;
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
