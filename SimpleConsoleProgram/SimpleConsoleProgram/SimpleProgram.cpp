#include<iostream>;
using namespace std;

int main() {
	int numberOfLanguages; //declaring an integer variable
	cout << "Hello Reader \n"
		<< "Welcome to C++ \n"; // printing to the console

	cout << "Hoe many programming languages have you used? : ";
	cin >> numberOfLanguages; //prompting the user for an input
	if (numberOfLanguages < 1) { // checking if the number of languages is less than 1
		cout << "Read the preface. You may prefer \n"
			<< "a more elementry book by the same author. \n";
	}
	else { // if it's not less than 1
		cout << "Enjoy the book. \n";
	}
	return 0;
}

