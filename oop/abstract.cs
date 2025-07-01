using System;

abstract class Shape {
    public abstract int GetArea();
}

class Square : Shape {
    private int _side;

    public Square(int n) => _side = n;

    // getarea method in required to avoid compile error

    public override int GetArea() => _side * _side;

    static void Main() {
        var sq = new Square(12);
        Console.WriteLine($"Area of square with side {sq.GetArea()}");
    }
    // output of example square will be n*n or 144 total area 
}

// abstract class is a class that cannot be instantiated, but can be inherited from

// not possible to modify abstract class