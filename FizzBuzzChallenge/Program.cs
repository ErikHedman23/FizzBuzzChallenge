using FizzBuzzChallenge;
bool number = true;
var fizzBuzz = new FizzBuzz();
while (number)
{
    Console.WriteLine("Enter a number to see if it fizz, buzz, or fizzbuzz...");
    number = int.TryParse(Console.ReadLine(), out int challengeNum);
    if (challengeNum % 3 != 0 && challengeNum % 5 != 0)
    {
        number = false;
        Console.WriteLine("Your number neither fizzes nor buzzes...");
        break;
    }
    Console.WriteLine(fizzBuzz.FizzBuzzChallenge(challengeNum));
}