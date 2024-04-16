
//This is my first C# file and where I start teaching myself the very basics of C#.

int a = 10 + 1;
string b = "aaaaaAAAAAAAA" + "12"; //use double quotes, not singles
byte c = 255; //can be 0-255
char d = 'e'; //single quotes here

float e = 0.12345678901234567890f; //will round to 0.12345679  ------------ 9 digits
double g = 0.12345678901234567890; //will round to 0.12345678901234568  --- 17 digits
decimal f = 0.12345678901234567890m; //  ---------------------------------- 29 digits

Console.WriteLine(a + " " + b);

if (a == 1)
{
    Console.WriteLine("Good");
}
else if (a != 1)
{
    Console.WriteLine("Day");
}

//                                 --== TYPE CASTING ==--
//       -Implicit type casting can be done if the initial variable is already compatible
//       -Explicit type casting must be done when it is NOT compatible
//       -Remember that decimals will automatically round down.
//       -Too many type casts is probably a bad sign
//                                 vvvvvvvvvvvvvvvvvvvvvv
int intvar = 1;
double douvar = intvar;
Console.WriteLine(douvar + "(after IMPLICITLY turning into a double)");  

douvar += 2.733;
Console.WriteLine(douvar + "(added 2.733 just to demonstrate it's a double)");

int eggsplicit;
eggsplicit = (int)douvar;
Console.WriteLine(eggsplicit + "(after EXPLICITLY turning back into an int)");


//                           --== TRYPARSE ==--
//    -"If you ever need to do a conversion, think TryParse first" 
//    -can be thrown into an if-else statement to detect an error in conversion
//    -looks professional
//                           vvvvvvvvvvvvvvvvvv
string howieStr = "125mm";
int howieInt;
if (int.TryParse(howieStr, out howieInt))  //In laymen's terms: 'If Tryparse inputs howieStr and outputs howieInt, Success.'
{
    Console.WriteLine("Successfuly converted. Howie = " + howieInt);
}
else                                       // 'And if Tryparse does not output a howieInt, Failure.'
{
    Console.WriteLine("Error; Could not be converted to Int");
}