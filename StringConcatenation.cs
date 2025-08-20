/*
//The + operator can used between strings to combine them. This is called concatenation
string firstName = "John";
string lastName = "Doe";
string name  = firstName + lastName;
Console.WriteLine(name);

//NOTE : THAT WE HAVE ADDED A SPACE AFTER "JOHN" CREATE A SPACE
//BETWEEN firstName and lastName ON PRINT.

//You can also uuse the "string.Contact()" method to concatenate two strings
string firstName2 = "John";
string lastName2 = "Doe";
string name2 = string.Concat(firstName2, lastName2);
Console.WriteLine(name2);

//Adding Numbers and Strings
//WARNING!!! 
//C# uses the + operator for both addition and concatenation.
//REMEMBER: Numbers are added. String are concatenated.

//if you add two numbers, the result will be a number:
int x = 10;
int y = 20;
int z = x + y;

//If you add two strings, the result will be a string concatenation:
string x2 = "10";
string y2 = "20";
string z2 = x2 + y2;     */