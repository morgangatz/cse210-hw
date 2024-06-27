using System;
using System.Collections.Generic;

public static class ScriptureLibrary
{
    private static List<Scripture> _scriptures = new List<Scripture>
    {
        new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
        new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        new Scripture(new Reference("Philippians", 4, 6, 7), "Be careful for nothing; but in every thing by prayer and supplication with thanksgiving let your requests be made known unto God. And the peace of God, which passeth all understanding, shall keep your hearts and minds through Christ Jesus."),
        new Scripture(new Reference("Luke", 23, 34), "Then said Jesus, Father, forgive them; for they know not what they do. And they parted his raiment and cast lots."),
        new Scripture(new Reference("Matthew", 11, 28, 30), "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."),
        new Scripture(new Reference("Doctrine & Covennants", 88, 67), "And if your eye be single to my glory, your whole bodies shall be filled with light, and there shall be no darkness in you; and that body which is filled with light comprehendeth all things."),    
    };

    public static Scripture GetRandomScripture()
    {
        var random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}

