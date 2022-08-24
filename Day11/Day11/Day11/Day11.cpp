// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
//generally considered to be BAD!
using namespace std;


int main()
{
    //std - standard namespace
    //:: - scope resolution operator
    //<< - insertion operator
    //cout - console output stream
    std::cout << "Hello World!\n" << 5 << "\n";

    cout << sizeof(char) << "(bytes)";

    char best[] = "Batman";//adds a \0 - null terminator
    char meh[] = { 'A','q','u','a','m','a','n'};//does not add a \0
    cout << best << "\n" << meh << "\n";

    for (size_t i = 0; i < 10; i++)
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
}