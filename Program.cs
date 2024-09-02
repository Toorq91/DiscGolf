namespace DiscGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disc> bag = new List<Disc>
        {
            new Disc("Pixel", "Putter", DiscType.Putter, 2m, 4m, 0m, 0.5m,Stability.Stable, PlasticType.Electron),
            new Disc("Envy", "Putter", DiscType.Putter, 3m, 3m, -1m, 2m, Stability.Overstable, PlasticType.Electron),
            new Disc("Keystone", "Putter", DiscType.Putter, 2m, 4m, 0m, 0.5m, Stability.Stable, PlasticType.Electron),
            new Disc("Pyro", "Midrange", DiscType.Midrange,5m, 4m, 0m, 0.5m, Stability.Overstable, PlasticType.Neutron),
            new Disc("Crave", "Fairway driver", DiscType.FairwayDriver, 6.5m, 4m, 0m, 0.5m, Stability.Stable, PlasticType.Neutron),
            new Disc("Insanity", "Fairway driver", DiscType.FairwayDriver, 9m, 5m, -2.5m, 1.5m, Stability.Flippy, PlasticType.Fission),
            new Disc("Tern", "Distance driver", DiscType.DistanceDriver, 12m, 4m, 0m, 0.5m, Stability.Overstable, PlasticType.Star),
            new Disc("Shryke", "Distance driver", DiscType.DistanceDriver, 13m, 5m, -2m, 2m, Stability.Understable, PlasticType.Star),

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