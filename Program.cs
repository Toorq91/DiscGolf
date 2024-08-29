namespace DiscGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disc> bane = new List<Disc>
        {
            new Putter("Pixel", 3m, Stability.Stable, PlasticType.Electron),
            new Putter("Envy", 3m, Stability.Overstable, PlasticType.Electron),
            new Midrange("Pyro", 5m, Stability.Overstable, PlasticType.Neutron),
            new FairwayDriver("Crave", 6.5m, Stability.Stable, PlasticType.Neutron),
            new DistanceDriver("Tern", 12m, Stability.Overstable, PlasticType.Star),

        };
            foreach (var disc in bane)
            {
                disc.DisplayInfo();
                disc.Flight();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}