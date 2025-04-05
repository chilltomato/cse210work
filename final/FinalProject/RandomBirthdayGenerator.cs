using System;

class RandomBirthdayGenerator : RandomGenerator
{
    public override string Randomize()
    {
        // Random, safe date
        int year = random.Next(1970, 2023);
        int month = random.Next(1, 13);
        int day = random.Next(1, 29); // Simplified to avoid month-specific day limits

        DateTime randomDate = new DateTime(year, month, day);
        return randomDate.ToString("dd MMMM yyyy"); // Example: 04 April 1996
    }
}
