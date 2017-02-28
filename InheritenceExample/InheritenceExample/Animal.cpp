#include<iostream>
#include<string>


using namespace std;


class Animal {

private:
	string name;
	string breed;
	int age;
public:
	Animal() {
		name = "there's no name";
		breed = "no breed";
		age = 0;
	}
	Animal(string n, string b, int a) {
		name = n;
		breed = b;
		age = a;
	}
	void setAge(int a) {
		age = a;
	}
	void setName(string n) {
		name = n;
	}
	void setBreed(string b) {
		breed = b;
	}

	int getAge()
	{
		return age;
	}
	string getName() {
		return name;
	}
	string getBreed() {
		return breed;
	}
	void display() {
		cout << "your animal's name is " << getName() << endl;
		cout << "your animal is " << getAge() << " years old" << endl;
	}
};

class Dog : public Animal {
public:
	void display() {
		cout << "sdfasdsad " << getName() << endl;
		cout << "your animal is " << getAge() << " years old" << endl;
	}
};

int main() {
	Dog dog;
	dog.setName("arzeesh");
	dog.setAge(100);
	dog.display();
	system("PAUSE");
	return 0;

}

