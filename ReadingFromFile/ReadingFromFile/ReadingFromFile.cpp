#include<iostream>;
#include<string>;
#include<fstream>;
using namespace std;

int main() {
	string firstName, lastName;
	int score;
	ifstream inputStream;

	inputStream.open("in.txt");

	inputStream >> score;
	inputStream >> firstName >> lastName;

	cout << "First name is: " << firstName << " and the last name is " << lastName << endl;
	cout << "The score is " << score << endl;

	inputStream.close();

	
}