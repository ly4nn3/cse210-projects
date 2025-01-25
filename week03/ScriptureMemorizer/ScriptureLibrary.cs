public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _random = new Random();
        _scriptures = new List<Scripture>();
        InitializeLibrary();
    }

    private void InitializeLibrary()
    {
        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "\nFor God so loved the world, that he gave his only begotten Son,\nthat whosoever believeth in him should not perish, but have everlasting life."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Matthew", 24, 30, 31),
            "\nAnd then shall appear the sign of the Son of man in heaven: and then shall all the tribes of the earth mourn,\nand they shall see the Son of man coming in the clouds of heaven with power and great glory.\nAnd he shall send his angels with a great sound of a trumpet,\nand they shall gather together his elect from the four winds, from one end of heaven to the other."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Luke", 12, 29, 32),
            "\nAnd seek not ye what ye shall eat, or what ye shall drink, neither be ye of doubtful mind.\nFor all these things do the nations of the world seek after: and your Father knoweth that ye have need of these things.\nBut rather seek ye the kingdom of God; and all these things shall be added unto you.\nFear not, little flock; for it is your Father's good pleasure to give you the kingdom."
        ));
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}