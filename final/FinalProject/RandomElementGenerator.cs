using System;
using System.Collections.Generic;

class RandomElementGenerator : RandomGenerator
{
    private List<string> elements = new List<string> { "Fire", "Water", "Earth", "Air", "Electricity", "Ice", "Shadow", "Music", "Magic", "Null"};

    public override string Randomize()
    {
        return elements[random.Next(elements.Count)];
    }
}
