// Definition of class DeckOfCards that 
// represents a deck of playing cards.
#if !defined DECKOFCARDS_H
#define DECKOFCARDS_H

#include <string>
#include <array>
using namespace std;

#include "Card.h"

// DeckOfCards class definition
class DeckOfCards 
{
public:
    // Class globals, NOT global globals!
   static const int numberOfCards{52};
   static const int faces{13};
   static const int suits{4};

   DeckOfCards(); // constructor initializes deck
   void shuffle(); // shuffles cards in deck
   void deal() const; // deals cards in deck

private:
   array<Card, numberOfCards> deck; // represents the deck of cards
}; 

#endif