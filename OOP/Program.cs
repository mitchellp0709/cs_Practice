using System;
/////////////////////////////////////////////
//classes
/////////////////////////////////////////////



class MainClass {
  public static void Main (string[] args){
    //Instantiating the class
    Dog sparky = new SmallDog("Sparky", 5);
    sparky.bark();
  }
}

//creating a new class
class Dog {
  protected string name;
  protected int age;

  //The constructor comes in the form of a method bearing the classes name
  public Dog(string name, int age){
    this.name = name;
    this.age = age;
  }
  

  public virtual void bark(){
    Console.WriteLine(this.name + " barks");
  }

}



class SmallDog: Dog{
  public SmallDog(string name, int age) : base(name, age) { }

  public override void bark(){
    Console.WriteLine(this.name + " yaps!");
  }
}



/////////////////////////////////////////////
//Static methods and properties
/////////////////////////////////////////////


class SecondClass {
  public static void Main(string[] args){
    Calculator.calculate(2, 2, "+");
    Calculator.showLastResult();

  }
}

class Calculator {
  //declare a static property
  private static int lastResult = 0;

  public static void calculate(int num1, int num2, string op){
    //using a switch statement since C# deosn't have an eval function
    switch(op){
      case "+":
        lastResult = num1 + num2;
        break;
      case "-":
        lastResult = num1 - num2;
        break;
      case "*":
        lastResult = num1 * num2;
        break;
      case "/":
        lastResult = num1 / num2;
        break;
      default:
        break;
    }
  }
  public static void showLastResult(){
    Console.WriteLine(lastResult);
  }
}
