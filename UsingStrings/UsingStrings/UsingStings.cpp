#include<iostream>;
#include<string>;
using namespace std;

int main() {
	string dogName;
	int actualAge;
	int humanAge;

	cout << "How old is your dog?" << endl;
	cin >> actualAge;

	humanAge = actualAge * 7;
	cout << "what's the name of your dog??" << endl;
	cin >> dogName;

	cout << dogName << " 's is approximately equivalent to a "
		<< humanAge << " year old human." << endl;

	return 0;
}