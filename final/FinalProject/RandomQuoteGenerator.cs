using System;
using System.Collections.Generic;

class RandomQuoteGenerator : RandomGenerator
{
    private List<string> quoteStartPool = new List<string>
    {
        "you know what they say,",
        "you know what I always says,",
        "my friend once told me",
        "a movie character once said",
        "have you heard"
    };
        private List<string> quoteEndPool = new List<string>
    {
        "Fortune favors the bold.",
        "To be or not to be, that is the question.",
        "Do or do not, there is no try.",
        "Keep your friends close and your enemies closer.",
        "only reason we desire to be great is because we need to be great",
        "The only thing we have to fear is fear itself.",
        "I tried so hard, and got so far, but in the end it doesn't even matter.",
        "Everybody praying for the end of times, Everybody hoping they could be the one",
        "not taking forever to grade is probally ideal"
    };


    public override string Randomize()
    {
        string start = quoteStartPool[random.Next(quoteStartPool.Count)];
        string end = quoteEndPool[random.Next(quoteEndPool.Count)];
        return $"{start}, {end}";
    }
}
