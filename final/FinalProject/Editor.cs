using System;

class Editor
{
    public static Character ModifyCharacter(Character character)
    {
        var nameGen = new RandomNameGenerator();
        var quoteGen = new RandomQuoteGenerator();
        var elemGen = new RandomElementGenerator();
        var BirthGen = new RandomBirthdayGenerator();
        int choice = 0;
        // Example modification logic (can be replaced with actual logic)
        character.DisplayCharacterInfo();
        while (choice != 6)
        {
            Console.WriteLine("what do you want to change?");
            Console.WriteLine("1. Name 2.gender 3.birthday 4.element 5.quote 6.exit");
            choice = int.Parse(Console.ReadLine());
             if (choice == 1) {
                 Console.Write("do you want to pick a random name? ");
                string randomName = Console.ReadLine().ToLower();
                 if (randomName == "y")
                {
                      character.Name = nameGen.Randomize();
                      Console.WriteLine($" ok, here you go, it's {character.Name}");
                }
                else
                {
                        Console.Write("What is your character's name? ");
                        character.Name = Console.ReadLine();
                }

            }
            if (choice == 2) {
                Console.Write("What is your character's gender? ");
                character.Gender = Console.ReadLine(); 
            }
            if (choice == 3){
                Console.Write("do you want to pick a random Birthday? ");
                string randomBirthday = Console.ReadLine().ToLower();
                if (randomBirthday == "y")
                {
                character.Birthday = BirthGen.Randomize();
                    Console.WriteLine($" ok, here you go, it's {character.Birthday}");
                }
                else
                {
                    Console.Write("What is your character's birthday (format: dd/MM/yyyy)? ");
                    character.Birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null).ToString("dd/MM/yyyy");
                }
            }
            if (choice == 4) {
                Console.Write("do you want to pick a random Element? ");
                string randomElement = Console.ReadLine().ToLower();

                if (randomElement == "y")
                {
                character.Element = elemGen.Randomize();
                Console.WriteLine($" ok, here you go, it's {character.Element}");
                }
                else
                {
                    Console.Write("What is your character's element? ");
                    character.Element = Console.ReadLine();
                }
            }
            if (choice == 5){
                    string more = "y";
                    while (more == "y")
                    {
                    Console.Write("Do you want to have a random quote? (y/n) ");
                    string randomQuote = Console.ReadLine().ToLower();
                    string quote;

                    if (randomQuote == "y")
                    {
                    quote = quoteGen.Randomize();
                    Console.WriteLine($"Ok, here you go, it's \"{quote}\"");
                    }
                    else
                    {
                     quote = Console.ReadLine();
                    }

                    character.Quotes.Add(quote);

                    Console.Write("Do you want to add another quote? (y/n) ");
                    more = Console.ReadLine().ToLower();
                    }

        }
    } 
    return character;
}
    }
