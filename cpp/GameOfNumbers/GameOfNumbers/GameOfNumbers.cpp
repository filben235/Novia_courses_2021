// GameOfNumbers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

bool guessGame(int guess, int answer);

int main()
{
    int answer = 0;
    char response = 'n';
    int guess = 0;
    
    srand(time(0));
    do {
        //generate random number between 1 and 1000
        answer = 1 + rand() % 1000;
        cout << "I have a number between 1 and 1000 \n"
             << "Can you guess my number? \n"
             << "Please type your first guess";
        cin >> guess;
        cout << endl;

        while (!guessGame(guess, answer)) cin >> guess;

        cout << "\nExcellent master! Your answer is correct! \n"
             << "Would you like to play again? (y or n)?";
        cin >> response;
        cout << endl;

    } while (response == 'y');
}

bool guessGame(int guess, int answer) {
    if (guess == answer) {
        return true;
    } 

    if (guess < answer) {
        cout << "Too low, Try again \n";
    } else cout << "Too high, Try again \n";
    return false;
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
