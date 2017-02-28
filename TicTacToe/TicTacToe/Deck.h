#pragma once
#include <ostream>
#include <string>
using namespace std;

class Deck {
private:
	char list[9];
	int player1_choices[9];
	int player2_choices[9];
public:
	Deck();
	char* getList();
	friend ostream & operator<<(ostream &s, Deck deck);
};
