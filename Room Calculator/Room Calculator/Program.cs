class Program
{
    public static void Main()
    {

        var OnemoAgain = false;
        Console.WriteLine(" Welcome to the Room Measurement Program!");
        string rm = GetUserInput("What room would you like to measure?");
          string room = (Console.ReadLine());
        Console.WriteLine()




            while(OnemoAgain==true )
            { 
            string len = GetUserInput($"Please enter the length of the {room}");
            double length = double.Parse(len);

            string wid = GetUserInput($"Please input a width for the {room}");
            double width = double.Parse(wid);

            string hei = GetUserInput($"Please input a height for the {room}");
            double height = double.Parse(hei);

            double area = GetArea(length, width);
            Console.WriteLine("Your area is: " + area);

            double volume = GetVolume(length, width, height);
            Console.WriteLine("Your volume is: " + volume);

            }
    }
    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return input;
    }
    public static double GetArea(double length, double width)
    {
        return length * width;
    }
    public static double GetVolume(double length, double width, double height)
    {
        return length * width * height;
    }
}