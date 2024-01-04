

//do
//{

//} while (true);

//while (true)
//{

//}

bool isValidAge;
int age;

do
{
	Console.WriteLine("What's your age: ");
	string ageText = Console.ReadLine();

	isValidAge = int.TryParse(ageText, out  age); 

	if (isValidAge == false )
	{
		Console.WriteLine("That was an invalid age.");
	}
} while (isValidAge == false);

Console.WriteLine($"Your age is {age}");