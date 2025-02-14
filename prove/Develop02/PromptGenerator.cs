using System;
using System.Collections.Generic;

public class Promptgenerator
{         
    private List<string> prompts;
    private Random random;
    public Promptgenerator()
    {
        prompts = new List<string>
        {
            "If I could have 1 thing I can do over today, what would that be?",
            "What was the best part of my day?",
            "Who's the most interesting person I interacted with today?",
            "What could I get better at?",
            "What's one thing I wish I done today",
        };
    }
    public string GetPrompt()
    {
        random = new Random();
        int promptIndex = random.Next(prompts.Count);
        return prompts[promptIndex];
    }
}
