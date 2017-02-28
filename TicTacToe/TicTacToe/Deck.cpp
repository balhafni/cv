#include "Deck.h"
#include <string>
#include <ostream>
#include <iostream>

using namespace std;

Deck::Deck() {
	for (int i = 0; i < sizeof(list); i++) {
		list[i] = ' ';
	}
	for (int i = 0; i < sizeof(player1_choices); i++) {
		player1_choices[i] = ' ';
	}
	for (int i = 0; i < sizeof(player2_choices); i++) {
		player2_choices[i] = ' ';
	}
}

char* Deck::getList() {
	char* c = list;
	return c;
}




 ostream & operator<<(ostream & s, Deck deck)
 {
	 string res = "";
	 int count = 0;
	 for (int i = 0; i < 3; i++) {
		 res = res + "\t" + deck.list[i * 2 + count] + "\t" + "|" + "\t" + deck.list[i * 2 + count + 1] + "\t"
			 + "|" + "\t" + deck.list[i * 2 + count + 2] + "\n" + "\t\t|" + "\t\t|" + "\n";
		 if (i != 2) {
			 res = res + "________________________________________________\n";
		 }
		 count++;
	 }
	 s << res;
	 return s;
 }


