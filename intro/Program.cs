using System.Collections;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, does this work??!");


string myVariable = "Hello World";
int myConstant = 6;
Console.WriteLine(myVariable+ " " + myConstant);



// Console.WriteLine("What is your name?");

// string input = Console.ReadLine();

// Console.WriteLine("Hey there " + input);


ArrayList myList = new ArrayList();

myList.Add(1);
myList.Add(2);
myList.Add(3);

Console.WriteLine(myList[0]);


//Creating Hashtables

Hashtable myHashtable = new Hashtable();

myHashtable.Add("cheese", "gouda");
myHashtable.Add("bread", "rye");

Console.WriteLine(myHashtable);
Console.WriteLine(myHashtable["cheese"]);
Console.WriteLine(myHashtable["bread"]);


ArrayList newList = new ArrayList();

newList.Add(1);
newList.Add(2);
newList.Add(3);
newList.Add(4);
newList.Add(5);
newList.Add(6);
newList.Add(6);
newList.Add(7);
newList.Add(9);
newList.Add(10);

Console.WriteLine(newList.Count);

newList.RemoveAt(0);
newList.Insert(0, 55);

foreach(int num in newList){
  Console.WriteLine(num);
}

newList.RemoveAt(0);


static int addNums(int x, int y){
  return x + y;
}

Console.WriteLine(addNums(10, 5));