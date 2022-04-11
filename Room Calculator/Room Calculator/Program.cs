
        var Continue_Running = false;
Console.WriteLine(" Welcome to the Room Measurement Program!");
do
{
   
    Console.WriteLine(" What room would you like to measure?");
    string room = Console.ReadLine();

    Console.WriteLine("Please enter the length of the " + room + " in feet.");

    decimal length = decimal.Parse(Console.ReadLine());

    Console.WriteLine(" Please enter the width of the " +room +  " in feet.");

    decimal width = decimal.Parse(Console.ReadLine());

    Console.WriteLine(" Please enter the height of the room in feet. ");

    decimal height = decimal.Parse(Console.ReadLine());

    decimal area = length * width;
    decimal perimeter = 2 * (length + width);
    decimal volume = (length * width * height);

    Console.WriteLine(" The area for the " + room + " is " + area + " feet");
    Console.WriteLine(" The perimeter for the " + room + " is " + perimeter + " feet");
    Console.WriteLine(" The volume for the " + room + " is " + volume + "feet");

    if (area <= 250) Console.WriteLine(" This is a small room.");
    else if(area > 250 && area <650) Console.WriteLine(" This is a medium sized room. ");
    else if (area > 650) Console.WriteLine(" This is a pretty big room. ");


    Console.WriteLine();
        Console.WriteLine(" Would you like to measure another room?");
        Console.WriteLine(" Please enter yes or no ");

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

Console.WriteLine(" Thanks for using the Room Measurement Program! See you next time.");

        
       
