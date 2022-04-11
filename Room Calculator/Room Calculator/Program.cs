
        var Continue_Running = false;
do
{
    Console.WriteLine("What room would you like to measure?");
    string room = Console.ReadLine();

    Console.WriteLine("Please enter the length of the " + room + " in feet.");

    decimal length = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the width of the " +room +  " in feet.");

    decimal width = decimal.Parse(Console.ReadLine());

    decimal area = length * width;
    decimal perimeter = 2 * (length + width);
    decimal volume = length * length * length;
   

    Console.WriteLine(" The area for " + room + " is " + area + " feet");
    Console.WriteLine(" The perimeter for " + room + " is " + perimeter + " feet");


    Console.WriteLine();
        Console.WriteLine(" Would you like to measure another room?");
        Console.WriteLine("Please enter yes or no");

        var input = (Console.ReadLine());
        if (input.ToLower() == "yes" || input.ToLower() == "y")
        {
            Continue_Running = true;
        }
        else
        {
            Continue_Running = false;
        }
    
}

while (Continue_Running == true);

        
       
