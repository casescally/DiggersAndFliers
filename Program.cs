using System.Collections.Generic;

namespace DiggersAndFliers {
    class Program {
        static void Main (string[] args) {

            Ant redAnt = new Ant ();
            BettaFish blackBettaFish = new BettaFish ();
            CopperheadSnake whiteSnake = new CopperheadSnake ();
            Earthworm pinkEarthworm = new Earthworm ();
            Finch greyFinch = new Finch ();
            Gerbil brownGerbil = new Gerbil ();
            Mouse whiteMouse = new Mouse ();
            Parakeet blueParakeet = new Parakeet ();
            Terrapin greenTerrapin = new Terrapin ();
            TimberRattlesnake brownTimberRattlesnake = new TimberRattlesnake ();

            Animals MyAnimals = new Animals ();
            List<IWalking> GroundHabitat = MyAnimals.MakeGroundHabitat ();
            List<IFlying> AirHabitat = MyAnimals.MakeAirHabitat ();
            List<IDigging> UndergroundHabitat = MyAnimals.MakeUndergroundHabitat ();
            List<ISwimming> WaterHabitat = MyAnimals.MakeWaterHabitat ();

        }
    }
}