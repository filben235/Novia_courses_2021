#include "Person.h"
#include <iostream>

using namespace std;

Person::Person() {
	SetName("Unknown");
	SetAge(0);
}

Person::~Person() {

}

bool Person::SetName(const string nameToSet) {
	m_Name = nameToSet;
	//yadayada check if succesful
	return true;
}

string Person::GetName() const {
	return m_Name; //yadayada some business rules to check
}

bool Person::SetAge(const unsigned int ageToSet) {
	if (ageToSet > 200) return false;
	m_Age = ageToSet;
	return true;
}

unsigned int Person::GetAge() const {
	return m_Age;
}

void Person::Walk() {
	cout << "The person is walking" << endl;
}