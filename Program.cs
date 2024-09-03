namespace DiscGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello and welcome to my discgolf bag :D\n");

            List<Disc> bag = new List<Disc>
        {
            new Disc("Pixel", "Putter", DiscType.Putter, 2m, 4m, 0m, 0.5m,Stability.Stable, PlasticType.Electron),
            new Disc("Envy", "Putter", DiscType.Putter, 3m, 3m, -1m, 2m, Stability.Overstable, PlasticType.Electron),
            new Disc("Keystone", "Putter", DiscType.Putter, 2m, 5m, -1m, 1m, Stability.Stable, PlasticType.Electron),
            new Disc("Pyro", "Midrange", DiscType.Midrange,5m, 4m, 0m, 2.5m, Stability.Overstable, PlasticType.Neutron),
            new Disc("Toro", "Midrange", DiscType.Midrange,4m, 2m, 1m, 3m, Stability.Overstable, PlasticType.Champion),
            new Disc("Mako3", "Midrange", DiscType.Midrange,5m, 5m, 0m, 0m, Stability.Stable, PlasticType.Star),
            new Disc("Fuse", "Midrange", DiscType.Midrange,5m, 6m, -1m, 0m, Stability.Understable, PlasticType.Opto),
            new Disc("Neutron Crave", "Fairway driver", DiscType.FairwayDriver, 6.5m, 5m, -1m, 1m, Stability.Stable, PlasticType.Neutron),
            new Disc("Fission Crave", "Fairway driver", DiscType.FairwayDriver, 6.5m, 5m, -1m, 1m, Stability.Understable, PlasticType.Fission),
            new Disc("Leopard3", "Fairway driver", DiscType.FairwayDriver, 7m, 5m, -2m, 1m, Stability.Understable, PlasticType.Champion),
            new Disc("Teebird", "Fairway driver", DiscType.FairwayDriver, 7m, 5m, 0m, 2m, Stability.Overstable, PlasticType.Star),
            new Disc("Volt", "Fairway driver", DiscType.FairwayDriver, 8m, 5m, -0.5m, 2m, Stability.Overstable, PlasticType.Neutron),
            new Disc("Diamond", "Fairway driver", DiscType.FairwayDriver, 8m, 6m, -3m, 1m, Stability.Tomahawk, PlasticType.Gold),
            new Disc("Neutron Insanity", "Fairway driver", DiscType.FairwayDriver, 9m, 5m, -2.5m, 1.5m, Stability.Flippy, PlasticType.Neutron),
            new Disc("Fission Insanity", "Fairway driver", DiscType.FairwayDriver, 9m, 5m, -2.5m, 1.5m, Stability.Flippy, PlasticType.Fission),
            new Disc("Wraith", "Distance driver", DiscType.DistanceDriver, 11m, 5m, -1m, 3m, Stability.Overstable, PlasticType.Star),
            new Disc("Neutron Time-Lapse", "Distance driver", DiscType.DistanceDriver, 12m, 5m, -1m, 3m, Stability.Overstable, PlasticType.Neutron),
            new Disc("Fission Time-Lapse", "Distance driver", DiscType.DistanceDriver, 12m, 5m, -1m, 3m, Stability.Overstable, PlasticType.Fission),
            new Disc("Tern", "Distance driver", DiscType.DistanceDriver, 12m, 6m, -3m, 2m, Stability.Understable, PlasticType.Star),
            new Disc("Shryke", "Distance driver", DiscType.DistanceDriver, 13m, 6m, -2m, 2m, Stability.Understable, PlasticType.Star),

        };
            foreach (var disc in bag)
            {
                disc.DisplayInfo();
                disc.Flight();
                Console.WriteLine();
            }

            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }
    }
}