

var Continue_Running = false;


    Console.WriteLine(" Welcome to the Number Analyzer! Please enter your name. ");
    string name = Console.ReadLine();
do
{
    Console.WriteLine(" Thanks for playing " + name + ". Please pick a number between 1 and 100. ");
    string number = Console.ReadLine();
    int num = int.Parse(number);

    if(num > 0 && num <= 100)
    {
        if (num % 2 == 0 && num < 25)
            Console.WriteLine(name + " The number " + num + " is even and less and 25. ");
        else if (num % 2 == 1 && num < 60)
            Console.WriteLine(name + " The number " + num + " is odd and less than 60. ");
        else if (num % 2 == 0 && num > 25 && num <= 60)
            Console.WriteLine(name + " The number " + num + " is even and between 25 and 61. ");
        else if (num % 2 == 1 && num > 60)
            Console.WriteLine(name + " The number " + num + " is odd and greater than 60. ");
        else if (num % 2 == 0 && num > 59)
            Console.WriteLine(name + " The number " + num + " is even and greater than 60. ");
    }
    else if
        (num <= 0 || num > 100)
        Console.WriteLine(" Sorry " + name +" " + num + " is not between 0 and 100. ");
    

    Console.WriteLine(" Would you like to choose another number " +name+ "? Type yes to pick again. Anything else will exit. ");

    var answer = Console.ReadLine();

    if (answer.ToLower() == "yes" || answer.ToLower() == "y")

    { Continue_Running = true; }

    else
    {
        Continue_Running = false;
    }
   
}
while (Continue_Running == true);

Console.WriteLine(" Thanks for playing " + name + ". See you soon. ");





