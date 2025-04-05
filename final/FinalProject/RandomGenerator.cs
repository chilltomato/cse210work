using System;
using System.Collections.Generic;

abstract class RandomGenerator
{
    protected static Random random = new Random();
    public abstract string Randomize(); 
}
