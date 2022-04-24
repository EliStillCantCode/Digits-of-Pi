Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();
string pi = "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";

var isConvertible = false;
var rDigitsInt = 0;

while (!isConvertible)
{
    Console.Clear();
    Console.WriteLine("How many digits of Pi do you want? 1-100");
    var requestedDigits = Console.ReadLine();

    isConvertible = int.TryParse(requestedDigits, out rDigitsInt);
}

Console.Clear();

int startIndex = 0;
int length = rDigitsInt;
String trimmedPi = pi.Substring(startIndex, length);
Console.WriteLine(trimmedPi);
