using System.Collections.Generic;

namespace DiggersAndFliers {
    public class Animals {
        public List<Ant> Ants = new List<Ant> ();
        public List<BettaFish> BettaFish = new List<BettaFish> ();
        public List<CopperheadSnake> CopperheadSnakes = new List<CopperheadSnake> ();
        public List<Earthworm> EarthWorms = new List<Earthworm> ();
        public List<Finch> Finches = new List<Finch> ();
        public List<Gerbil> Gerbils = new List<Gerbil> ();
        public List<Mouse> Mice = new List<Mouse> ();
        public List<Parakeet> Parakeets = new List<Parakeet> ();
        public List<Terrapin> Terrapins = new List<Terrapin> ();
        public List<TimberRattlesnake> TimberRattlesnakes = new List<TimberRattlesnake> ();

        public List<IDigging> MakeUndergroundHabitat () {
            List<IDigging> Arrangment = new List<IDigging> ();
            Arrangment.Add (new Earthworm ());
            Arrangment.Add (new Ant ());
            Arrangment.Add (new CopperheadSnake ());

            return Arrangment;
        }
        public List<IFlying> MakeAirHabitat () {
            List<IFlying> Arrangment = new List<IFlying> ();
            Arrangment.Add (new Parakeet ());

            return Arrangment;
        }

        public List<IWalking> MakeGroundHabitat () {
            List<IWalking> Arrangment = new List<IWalking> ();
            Arrangment.Add (new TimberRattlesnake ());
            Arrangment.Add (new Terrapin ());

            return Arrangment;
        }

        public List<ISwimming> MakeWaterHabitat () {
            List<ISwimming> Arrangment = new List<ISwimming> ();
            Arrangment.Add (new BettaFish ());

            return Arrangment;
        }
    }
}