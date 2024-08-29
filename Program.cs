namespace DiscGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disc> bag = new List<Disc>
        {
            new Putter("Pixel", "Putter", 2m, 4m, 0m, 0.5m,Stability.Stable, PlasticType.Electron),
            new Putter("Envy", "Putter", 3m, 3m, -1m, 2m, Stability.Overstable, PlasticType.Electron),
            new Putter("Keystone", "Putter", 2m, 4m, 0m, 0.5m, Stability.Stable, PlasticType.Electron),
            new Midrange("Pyro", "Midrange", 5m, 4m, 0m, 0.5m, Stability.Overstable, PlasticType.Neutron),
            new FairwayDriver("Crave", "Fairway Driver", 6.5m, 4m, 0m, 0.5m, Stability.Stable, PlasticType.Neutron),
            new DistanceDriver("Tern", "Distance driver", 12m, 4m, 0m, 0.5m, Stability.Overstable, PlasticType.Star),
            new DistanceDriver("Shryke", "Distance driver", 13m, 5m, -2m, 2m, Stability.Understable, PlasticType.Star),
            new FairwayDriver("Insanity", "Fairway driver", 9m, 5m, -2.5m, 1.5m, Stability.Flippy, PlasticType.Fission),

        };
            foreach (var disc in bag)
            {
                disc.DisplayInfo();
                disc.Flight();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}