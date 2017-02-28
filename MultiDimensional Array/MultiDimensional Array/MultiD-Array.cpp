
#include<iostream>;
using namespace std;

const int I = 2;
const int J = 2;
const int K = 2;
const int X = 2;
const int Y = 2;
int *****fDarray;


void printArray();

int main() {
	
	//creating the arrays using ptrs 
	fDarray = new int ****[I];
	for (int i = 0; i < I; i++)
	{
		fDarray[i] = new int ***[J];

		for (int j = 0; j < J; j++)
		{
			fDarray[i][j] = new int**[K];

			for (int k = 0; k < K; k++)
			{
				fDarray[i][j][k] = new int*[X];

				for (int x = 0; x < X; x++)
				{
					fDarray[i][j][k][x] = new int[Y];
				}
			}
		}
	}


	//filling the array with zeroes
	for (int i = 0; i < I; i++)
	{
		for (int j = 0; j < J; j++)
		{
			for (int k = 0; k < K; k++)
			{
				for (int x = 0; x < X; x++)
				{
					for (int y = 0; y < Y; y++)
					{
						fDarray[i][j][k][x][y] = 0;
					}
				}
			}
		}
	}

	//filling the array manually
	fDarray[0][0][0][0][0] = 10;
	fDarray[0][0][0][0][1] = 20;
	fDarray[0][0][0][1][0] = 30;
	

	
	printArray(); //printing the array


	//deallocation
	for (int i = 0; i < I; i++)
	{
		for (int j = 0; j < J; j++)
		{
			for (int k = 0; k < K; k++)
			{
				for (int x = 0; x < X; x++)
				{
					delete [] fDarray[i][j][k][x];
				}
				delete[] fDarray[i][j][k];
			}
			delete[] fDarray[i][j];
		}
		delete[] fDarray[i];
	}
	delete[] fDarray;

	return 0;

}

void printArray() {

	for (int i = 0; i < I; i++)
	{
		for (int j = 0; j < J; j++)
		{
			for (int k = 0; k < K; k++)
			{
				for (int x = 0; x < X; x++)
				{
					for (int y = 0; y < Y; y++)
					{
						cout << fDarray[i][j][k][x][y] << endl;
					}
				}
			}
		}
	}


}