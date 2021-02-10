#include <iostream>
#include <string>
#include <vector>

#include "Record.h"


int main()
{
	using std::cout;
	using std::vector;

	//The vector comes from the stl-library, similar to an array, but dynamic.
	vector<Record> books;

	Record temp;
	bool shouldContinue = true;

	while(shouldContinue==true )
	{
		shouldContinue=FillinRecord(temp);
		if (shouldContinue == true) {
			books.push_back(temp);
		}
	}
	
	const int size=books.size();

	for(int index=0; index< size; index++)
	{
		Record& rTheIndexedBook = books.at(index);
		ShowRecord(rTheIndexedBook);
	}


	
}

