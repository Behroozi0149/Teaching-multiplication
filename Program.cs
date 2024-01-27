try
{
    var rnd = new Random();
    var j = 0;
    var name = "user";
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Hello, welcome to the multiplication training program");
    Console.Write("Would you like to say your name?");
    var getname = Console.ReadLine();
    if (getname == "yes")
    {
        Console.Write("OK, so please enter your name:");
        name = Console.ReadLine();
    }
    else if (getname == "no")
    {
        Console.WriteLine("Ok");
    }
    Console.Write("Would you like me to ask you a few questions(Example:10 to 15)?");
    var Question = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();
    for (int i = 0; i < Question; i++)
    {
        var a = rnd.Next(1, 10);
        var b = rnd.Next(1, 10);
        var osanswer = a * b;
        Console.WriteLine($"{a}*{b}= ?");
        Console.Write($"enter the answer {name}:");
        var answer = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();
        if (answer == osanswer)
        {
            Console.WriteLine($"Well done {name}, your answer was correct");
            j++;
        }
        else
        {
            Console.WriteLine($"Sorry {name}, but you gave a wrong answer");
            Console.WriteLine($"correct answer={osanswer}");
        }
        Console.WriteLine();
    }
    if (Question / 2 == j)
    {
        Console.WriteLine("good");
    }
    else if (Question == j)
    {
        Console.WriteLine("very good");
    }
    Console.WriteLine($"The number of correct answers is {j}");
    File.AppendAllText("Correct.Answer", Question + "\n");
    if (j == Question)
    {
        Console.WriteLine("Well done, you answered well");
    }
    Console.ResetColor();
    Thread.Sleep(100);
}
catch
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Error, please run the program again and provide more detailed information.");
    Console.ResetColor();
}
