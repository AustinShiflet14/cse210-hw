using System;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();

        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"));

        _scriptures.Add(new Scripture(
            new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be and men are that they might have joy"));

        _scriptures.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God"));
    }

    public Scripture GetRandomScripture()
    {
        Random rand = new Random();
        int index = rand.Next(_scriptures.Count);
        return _scriptures[index];
    }
}