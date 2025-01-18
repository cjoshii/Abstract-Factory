// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! What animal kind of animal do you want to play with?");
Console.WriteLine("1. Wild");
Console.WriteLine("2. Domestic");

int choice = 0;

while(true) {
    try
    {
        string? input = Console.ReadLine();
        
        if(input == null)
        {
            Console.WriteLine("Invalid choice, please try again");
            continue;
        }

        choice = int.Parse(input);
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid choice, please try again");
    } 
}

IAnimalFactory? factory = null;

switch (choice)
{
    case 1:
        factory = new WildAnimalFactory();
        break;
    case 2:
        factory = new DomesticAnimalFactory();
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

if (factory != null)
{
    IDog dog = factory.CreateDog();
    Console.WriteLine((choice == 1 ?  "Wild" : "Domestic") + " Dog " + dog.Speak());

    ICat cat = factory.CreateCat();
    Console.WriteLine((choice == 1 ?  "Wild" : "Domestic") + " Cat " + cat.Speak());
}