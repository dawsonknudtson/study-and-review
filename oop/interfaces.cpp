#include <iostream>
using namespace std;

class IAnimal {
public:
    virtual void makeSound() = 0;  // Pure virtual function
    virtual ~IAnimal() = default;  // Virtual destructor
};

class Dog : public IAnimal {
public:
    void makeSound() override {
        cout << "Woof" << std::endl;
    }
};

class Cat : public IAnimal {
public:
    void makeSound() override {
        cout << "Meow" << std::endl;
    }
};