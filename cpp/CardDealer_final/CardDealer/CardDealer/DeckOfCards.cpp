// Member-function definitions for class DeckOfCards that simulates
// the shuffling and dealing of a deck of playing cards.
#include <iostream>
#include <iomanip>
#include <cstdlib> // prototypes for rand and srand
#include <ctime> // prototype for time
using namespace std;

#include "DeckOfCards.h" // DeckOfCards class definition

// no-argument DeckOfCards constructor intializes deck
DeckOfCards::DeckOfCards() 
{
    // initialize suit array
    // Method global, remembering variable. 
    // Auto converts char* string to moderna string. This means all DeckOfCards instances share the same card 'info'.
    // Some compiler (old ones) could choke on the syntax and need specifi conversion,
    // like this: static string suit[suits]{string("Hearts"), string("Diamonds"), string("Clubs"), string("Spades")};


    //variabel suit med storleken 4, static för att bara skapa första gången
    static string suit[suits]{"Hearts", "Diamonds", "Clubs", "Spades"};

    // initialize face array
    static string face[faces]{"Ace", "Deuce", "Three", "Four", "Five","Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

    // set values for deck of 52 Cards
    for (size_t i{0}; i < deck.size(); ++i) 
    {
        // % is a modulo operator. It gives remainder of two numbers on division as result, after multiply with *cut division result*.
        // eg 12%3 == 0 13%3 == 1, 14%3==2 15%3 = and so on, slicing into 3 groups
        // / division returns floating point number, then *cut down* to integer.
        // so, 
        deck[i].face = face[i % faces];
        deck[i].suit = suit[i / faces];
    } 

    srand(time(nullptr)); // seed 
} 

// shuffle cards in deck
void DeckOfCards::shuffle() 
{
   // shuffle cards randomly
    for (size_t index{0}; index < deck.size(); index++) {
        // Swap the cards position
        int randomIndex{rand() % numberOfCards};

        Card temp = deck[index];
        deck[index] = deck[randomIndex];
        deck[randomIndex] = temp;
    } 
} 

// deal cards in deck
void DeckOfCards::deal() const 
{
    // defaults
    char rowtabHandler{ '\t' };
    size_t columnCount = 2;

   // display each card’s face and suit
   for (size_t index = 0; index < deck.size(); index++) 
   {
       // End of line or column tab?
       if ((index + 1) % columnCount)
           rowtabHandler = '\t';
       else
           rowtabHandler = '\n';

      cout << right << setw(5) << deck[index].face << " of "<< left << setw(8) << deck[index].suit << rowtabHandler;
   } 
} 
