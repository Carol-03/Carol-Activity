/*
//C# has a bool data type, which can take the values trus or false

//Boolean Values. a boolean data type is declared with the bool keyword and
//can only take the values trus or false

bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun); 
Console.WriteLine(isFishTasty);

///Boolean Expression 
//returns a boolean value: True or False, by comparing values/variables
//this is useful to build logic, and find answer
// for example. you can use a comparison operator, such as the greater tahn (>)
//operator to find out if an expression (or a variable) is trus.
int x = 10;
int y = 9;
Console.WriteLine(x > y);
Console.WriteLine(10 > 9);

//we use the equal to (==) operator to evaluate an expression:
int x2 = 10;
Console.WriteLine(x2 == 10);
Console.WriteLine(10 == 15);

//In the example below we use the >= comparison operatoor to find out if the age (25)
// is greater thab OR equal to the voting age limit, which is set to 18:
int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);

//would be to wrap the code above in an if...else statement, so we can perform
// different actions depending on the result:
int myAge2 = 25;
int votingAge2 = 18;

if (myAge2 >= votingAge2)
{
    Console.WriteLine("Old enough to vote!");
}
else
{
    Console.WriteLine("Not old enough to vote.");
}

//The boolean value of an expression is the basis for all C# comparison and conditions
//You will learn more about conditions (if....else) in the next chapter. */