// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What's your name?");
var name = Console.ReadLine();
if (name == "")
{
    Console.WriteLine("You didn't fill in your name properly, please try again.");
    name = Console.ReadLine();
}
else
{
    Console.WriteLine($"Hello, {name}!");
    Console.WriteLine("thanks for filling in your name, how are you doing?");
    var statusResponse = Console.ReadLine();
    if (String.IsNullOrEmpty(statusResponse))
    {
        Console.WriteLine("Please fill in your mood.");
        statusResponse = Console.ReadLine();
    }
    else
    {
        switch (statusResponse)
        {
            case "Good":
                Console.WriteLine("Awesome I also feel good!");
                break;
            case "Bad":
                Console.WriteLine("Oh, that's too bad. I suggest drinking Nalu.");
                break;
            case "Ok":
                Console.WriteLine("Just Ok? Go for a walk, it will definitely be more than ok after that!");
                break;
            default:
                Console.WriteLine($"You feel {statusResponse} and that's more then Oke!");
                break;
        }    
    }

    Console.WriteLine("bye bye");
    
}

