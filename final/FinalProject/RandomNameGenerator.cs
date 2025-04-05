using System;
using System.Collections.Generic;

class RandomNameGenerator : RandomGenerator
{
private List<string> names = new List<string>
{
    "Alex", "Steve", "Efe", "Nephi", "Maya", "Liam", "Zara", "Noah", "Isla", "Kai", "Juno", "Milo", "Tara", "Leo", "Nova", "Finn", "Skye", "Aria", "Ezra", "Nico", "Rhea", "Jade", "Asher", "Luna", "Omar", "Elio", "Sage", "Yara", "Theo", "Nyx", "Junior", "Tristan", "Ency", "Marty"
};

    public override string Randomize()
    {
        string randomName = names[random.Next(names.Count)];
        return randomName;
    }
}
