Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();
var pi = "3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679";
string? digits = ("3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679").Length.ToString();

var isConvertible = false;
var rDigitsInt = 0;

while (!isConvertible)
{
    Console.Clear();
    Console.WriteLine("How many digits of Pi do you want? 1-100");
    var requestedDigits = Console.ReadLine();

    isConvertible = int.TryParse(requestedDigits, out rDigitsInt);
}