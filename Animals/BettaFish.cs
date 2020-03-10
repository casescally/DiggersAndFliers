using System;

namespace DiggersAndFliers {
    public class BettaFish : ISwimming {

        public int MaximumDepth { get; } = 100;

        public void Swim () {
            Console.WriteLine ("Animal is now swimming");
        }

    }
}