bool validNumber = false;
int number = 0;

do
{
    Console.WriteLine("Enter a valid number: ");
    validNumber = int.TryParse(Console.ReadLine(), out number);
    Console.WriteLine($"Number: {number}, valid: {validNumber}");
} while (validNumber == false);