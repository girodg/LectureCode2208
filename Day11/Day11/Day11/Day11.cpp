// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
//generally considered to be BAD!
using namespace std;

enum Superpowers
{
    Money, Speed, Strength, Charisma
};

//forward declaration
void printMe(Superpowers power);

int main()
{
    Superpowers powers = Superpowers::Speed;

    printMe(powers);
    cout << powers << "\n";
    //std - standard namespace
    //:: - scope resolution operator
    //<< - insertion operator
    //cout - console output stream
    std::cout << "Hello World!\n" << 5 << "\n";

    cout << sizeof(char) << "(bytes)";

    char best[] = "Batman";//adds a \0 - null terminator
    char meh[] = { 'A','q','u','a','m','a','n'};//does not add a \0
    cout << best << "\n" << meh << "\n";

    int nums[] = { 1,2,3,4,5 };
    int* numbers = new int[5] {1, 2, 3, 4, 5};
    cout << "Meh: " << sizeof(numbers) << "\n";
    delete[] numbers;
    numbers = nullptr;
    for (size_t i = 0; i < sizeof(nums) / sizeof(int); i++)
    {

    }

    bool looping = true;
    int counter = 0;
    while (true)
    {
        if (counter < 100)
        {
            counter++;
            continue;
        }
        break;
    }

    auto n = 5;

    srand(time(NULL));
    int rando = rand() % 101;//0-100  modulus operator

    vector<int> scores;//stack instance
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());
    for (size_t i = 0; i < scores.size(); i++)
    {
        cout << scores[i] << "\n";
    }
    cout << scores.capacity() << "\n";
}

void printMe(Superpowers power)
{
    switch (power)
    {
    case Money:
        cout << "Money\n";
        break;
    case Speed:
        break;
    case Strength:
        break;
    case Charisma:
        break;
    default:
        break;
    }
}
