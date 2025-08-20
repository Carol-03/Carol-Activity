/*
// The if statement 
// Use the if statement to specify a block of C# code to be executed i a condition is True

if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}
int x = 20;
int y = 18;
if (x > y)
{
    Console.WriteLine("x is greater than y");
}

//The else statement to specify a block of code to be executed if the conditions is false
int time = 20;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening");
}

//The else if statement 
//use the else if statement to specify a new condition if the first condition is False

int time2 = 22;
if (time2 < 10)
{
    Console.WriteLine("Good Morning");
}
else if (time2 < 20)
{
    Console.WriteLine("Good day");
}
else
{
    Console.WriteLine("Good evening");
}

//Short Hand If Else
// There is also a short-hand if else, which is known as the ternary operator because it consist
//of three operands. It can be used to replace multiple lines of code with a single line.
//It is often used to replace simple if else statements
//Syntax 
//variable = (condition) ? expressionTrue: expressionFalse;
//Instead of writing:
int time3 = 20;
if (time < 18)
{
    Console.WriteLine("Good day");
}
else
{
    Console.WriteLine("Good Evening");
}

//You can simply write:
int time4 = 20;
string result = (time4 < 18) ? "Good day" : "Good evening.";
Console.WriteLine(result); 

*/