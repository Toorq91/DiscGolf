namespace DiscGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Disc> bag = new List<Disc>
        {
            new Putter("Pixel", 2m, 4m, 0m, 0.5m,Stability.Stable, PlasticType.Electron),
            new Putter("Envy", 3m, 3m, -1m, 2m, Stability.Overstable, PlasticType.Electron),
            new Putter("Keystone", 2m, 4m, 0m, 0.5m, Stability.Stable, PlasticType.Electron),
            new Midrange("Pyro", 5m, 4m, 0m, 0.5m, Stability.Overstable, PlasticType.Neutron),
            new FairwayDriver("Crave", 6.5m, 4m, 0m, 0.5m, Stability.Stable, PlasticType.Neutron),
            new DistanceDriver("Tern", 12m, 4m, 0m, 0.5m, Stability.Overstable, PlasticType.Star),
            //new DistanceDriver("SockyBomb", 0m, (Stability)(-1), PlasticType.Star)

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