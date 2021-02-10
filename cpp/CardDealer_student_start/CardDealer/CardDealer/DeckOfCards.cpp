// Member-function definitions for class DeckOfCards that simulates
// the shuffling and dealing of a deck of playing cards.
#include <iostream>
#include <iomanip>
#include <cstdlib> // prototypes for rand and srand
#include <ctime> // prototype for time
using namespace std;

#include "DeckOfCards.h" // DeckOfCards class definition
#include "Card.cpp"

// no-argument DeckOfCards constructor intializes deck
DeckOfCards::DeckOfCards() 
{
   // initialize suit array
   
   // initialize face array
   
   // set values for deck of 52 Cards
    for (int i = 1; i <= numberOfCards, i++;) {
        deck[i].face = Card::arrface[1];
    };

   srand(time(nullptr)); // seed 
} 

// shuffle cards in deck
void DeckOfCards::shuffle() 
{
   // shuffle cards randomly
    
} 

// deal cards in deck
void DeckOfCards::deal() const 
{
   
   // display each card’s face and suit
    
} 
