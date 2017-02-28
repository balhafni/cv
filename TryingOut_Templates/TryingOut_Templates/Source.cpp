#include<iostream>

using namespace std;

template<class T>

T square(T x) {
	return x*x;
}

int main() {

	int i = square<int>(2);
	cout << "the value of i is " << i << endl;
	double j = square(2.5);
	cout << "the value of j is " << j << endl;

}