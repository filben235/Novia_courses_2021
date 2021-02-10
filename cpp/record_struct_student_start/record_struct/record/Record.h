#include <string>

struct Record
{
	std::string title;
	int			score;
};

bool FillinRecord(Record& rTheRecord);
bool ShowRecord(Record& rTheRecord);

