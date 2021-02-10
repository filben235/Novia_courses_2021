#if !defined CARD_H
#define CARD_H

#include <string>
using namespace std;

// Card structure definition
struct Card 
{
    static string face;
    static  string suit;
    //face = 1-13, suit = clubs,...
    static string arrface[13];
    static string arrsuit[4];
};
#endif

