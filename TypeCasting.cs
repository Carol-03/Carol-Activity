/*
// Type casting is when you assign a value of one data type to another type
// 1. In C#, there are two types of casting
//Implicit Casting (automatically) - converting a smaller type to a larger type size 
//char -> int -> long -> float -> double 
// 2. Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char 

//Implicit Casting, is done automatically when  passing a smaller size type to a larger size type:
int myInt = 9;
double myDouble = myInt;

Console.WriteLine(myInt);
Console.WriteLine(myDouble);

//Explicit Casting must be done manually by placing the type in parentheses in front of the value:
double myDouble2 = 9.78;
int myInt2 = (int) myDouble2;

Console.WriteLine(myDouble2);
Console.WriteLine(myInt2);

//Type Conversion Methods, it is also possible to convert data types explicity by using built-in methods, such as Convert.TooBoolean,
//Convert.ToDouble,Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long) :
int myInt3 = 10;
double myDouble3 = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt3));
Console.WriteLine(Convert.ToDouble(myInt3));
Console.WriteLine(Convert.ToInt32((int)myDouble3));
Console.WriteLine(Convert.ToString(myBool)); */
