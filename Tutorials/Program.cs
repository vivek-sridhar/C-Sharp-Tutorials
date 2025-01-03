Console.WriteLine("Hello World");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

String userInput = Console.ReadLine();

Console.WriteLine($"You entered {userInput.ToUpper()}");
Console.ReadKey();