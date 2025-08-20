/*
//Before we learned that Console.WriteLine() is used to Output (print) values.
//Now we will use Console.ReadLine() to get user input

//In this example below, the user can input his or hers username,
//which is stored in the variable userName. Then we print the value of userName

//Type your username and press enter 
Console.WriteLine("Enter username:");
//Create s string variable and get user input from the keyboard
//and store it in the variable
string userName = Console.ReadLine();
//Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

//User Input and Numbers, The "Console.ReadLine()" method returns a "string". Therefore, you canot get 
//information from anothe data type, such as "int"
//You cannot inmplicity convert type 'string' to 'int',
//You can convert any type explicitly by using one of the "Convert.To" methods
Console.WriteLine("Enter yor age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age); */

/*NOTE 
 * If you enter wrong input (e.g text in a numerical input), you will get an exception
 * or error message like "System.FormatException: 'Input string was not in a correct format.") */
 