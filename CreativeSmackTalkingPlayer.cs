using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> _tauntList = new List<string>
        {
            "Your mother was a hamster",
            "And your father smelled of elder berries",
            "You lint licker!!",
            "Fool of a took!"
        };

        public void RandomTaunt()
        {
            int rnd = new Random().Next(_tauntList.Count);
            Console.WriteLine(_tauntList[rnd]);
        }
    }
}