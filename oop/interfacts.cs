using System;

public interface IAnimal {
    void makeSound();
}

// Dog implements the IAnimal interface & Needs to implement the makeSound method
public class Dog : IAnimal {
    public void makeSound() {
        Console.WriteLine("Woof");
    }
}
// Cat class also needs to implement the makeSound method - because of the IAnimal Interface
public class Cat : IAnimal {
    public void makeSound() {
        Console.WriteLine("Meow");
    }
}

public class interfacts {
    public static void Main(string[] args) {
        IAnimal animal = new Dog();
        IAnimal animal2 = new Cat();

        // As you can see, we can create an instance of the Dog and Cat class and assign it to the IAnimal interface

        // You can then, call the methods

        animal.makeSound();
        animal2.makeSound();
    }
    
}