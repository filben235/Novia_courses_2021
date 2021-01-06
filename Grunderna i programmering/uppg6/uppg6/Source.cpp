#include <iostream>
#include <string> 
#include <ios> 
#include <limits>

using namespace std;

//checks that the input is valid
bool checkPoints(double points) {
	if (points >= 0 && points <= 30) {
		return true;
	}
	else return false;
}

//calculates the grade
int calculateGrade(double points) {
	if (points < 4)return 0;
	if (points == 30) return 5;
	else return int((0.25 * points) - 1.5);
}


int main() {
	double points;
	int grade;

	//user input
	cout << "Enter students points\n";
	cin >> points;
	//clears the buffer
	cin.ignore(numeric_limits<streamsize>::max(), '\n');
	
	
	//calculates grade if the input is valid
	if (checkPoints(points)) {
		grade = calculateGrade(points);

		//outputs grade and message
		switch (grade) {
		case 1:
		case 2:
			cout << "You scored a " << grade << " that's ok\n";
			break;
		case 3:
		case 4:
			cout << "You scored a " << grade << " nice job :)\n";
			break;
		case 5:
			cout << "You scored a 5, that's great :D\n";
			break;
		default:
			cout << "You scored a 0, nice job :E\n";
			break;
		}
	}

	//pauses the program
	system("pause");
	return 0;
}