#include <iostream>

class IAnimal {
public:
    virtual void makeSound() = 0;  // Pure virtual function
    virtual ~IAnimal() = default;  // Virtual destructor
};

class Dog : public IAnimal {
public:
    void makeSound() override {
        std::cout << "Woof" << std::endl;
    }
};

class Cat : public IAnimal {
public:
    void makeSound() override {
        std::cout << "Meow" << std::endl;
    }
};