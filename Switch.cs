int day = 0;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}

//The break Keyword 
//A break can save a lot execution time because it "ignores" the execution of all the rest
// of the code in the switch block.

//The default Keyword 
//The default keyword is optional and specifies some code to run if there is no case match:
int day2 = 10;
switch (day2)
{
    case 8:
        Console.WriteLine("Today is Saturday.");
        break;
    case 9:
        Console.WriteLine("Today is Sunday");
        break;
    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
         
}