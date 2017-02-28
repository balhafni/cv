#include <iostream>
using namespace std;
// Guksung An

int main() {
	int size = 3;
	// allocate 5d 3*3*3*3*3 array
	int***** fiveDim = new int****[size];
	for (int i = 0; i < size; ++i)
	{
		fiveDim[i] = new int***[size];
		for (int j = 0; j < size; ++j)
		{
			fiveDim[i][j] = new int**[size];
			for (int k = 0; k < size; ++k)
			{
				fiveDim[i][j][k] = new int*[size];
				for (int l = 0; l < size; ++l)
				{
					fiveDim[i][j][k][l] = new int[size]; // allocate done
					for (int m = 0; m < size; ++m)
					{
						// fill the array
						fiveDim[i][j][k][l][m] = m + 10 * l + 100 * k + 1000 * j + 10000 * i;

						// output the array
						cout << fiveDim[i][j][k][l][m] << endl;
					}

					// deallocate the array
					delete fiveDim[i][j][k][l];
				}
				delete[] fiveDim[i][j][k];
			}
			delete[] fiveDim[i][j];
		}
		delete[] fiveDim[i];
	}
	delete[] fiveDim; // deallocate done
	cin.get();
	// system("PAUSE");+
	return 0;
}