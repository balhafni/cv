#include <string>
using namespace std;



class Person
{
private:
	string name;
	int age;
public:
	void set_values(string n, int a);
	string get_name()const;
	int get_age()const;
};

