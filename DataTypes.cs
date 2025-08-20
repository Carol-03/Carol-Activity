/*
int myNum = 5;  //Integer (whole number)
double myDoubleNum = 5.99D; //Floating point number
char myLetter = 'D'; //Character
bool myBool = true; //Boolean
string myText = "Hello"; // String 


//Int, can store whole numbers from -2147483648 to 2147483647. 
//In general, the int data type is the preferred data type when we create variables with a numeric value
using System.Runtime.Intrinsics.X86;

int myNum = 100000;
Console.WriteLine(myNum);

//long, can store whole numbers from -9223372036854775808 to 922337036854775807. This is 
//used when int is not large enough to store the value. Note that you should end the value with an "L"
long myNum2 = 15000000000L;
Console.WriteLine(myNum2);

//Floating Point Types, use floating types whenever need a number with a decimal
// such as 99.9 or 3.14515. 
//the float and double data types can store fractional numbers. 
//Note that you should end the value with an "F" for floats and "D" for doubles

float myNum3 = 5.75F;
Console.WriteLine(myNum3);

double myNum4 = 19.99D;
Console.WriteLine(myNum4);

//Use float or double?
//The precision of a floating point value indicates how many digits the value
//can have after the decimal point. The precision of float is only six or seven decimal digits,
//while double variables have a precision of about 15 digits. Therefore it is safer to use double for most calculations.

//Scientific Numbers, a floatiing point number can also be a scientific number with an "e" to indicate the power of 10:
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);

//Booleans, is declared with the bool keyword and can only take the values true or false:
bool isCSharpFun    = true;
bool isFishTasty    = false;
Console.WriteLine(isCSharpFun);
Console.WriteLine(isFishTasty);

//Character, the char data type is used to store a single character. The character
//must be sorrounded by single qoutes,like 'A' or 'c'
char myGrade = 'B';
Console.WriteLine(myGrade);

//Strings, the data strings data type is used to store a sequence of characters (text).
//String values must be sorrounded by double quotes
string greeting = "Hello World";
Console.WriteLine(greeting);  */