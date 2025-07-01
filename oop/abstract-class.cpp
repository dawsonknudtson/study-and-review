#include <iostream>
using namespace std;

class Base {
    int x;


public : 
    virtual void fun() = 0;

    // constructor of Base class 
    Base(int i) {
        x = 1;
        cout << "constructor of base ball\n";
    }
};

class Derived : Base {
    int y;

    public : 
    // calling constructor of base class 
        Derived(int i, int j) : Base(i) {
            y = j;
        }
};

