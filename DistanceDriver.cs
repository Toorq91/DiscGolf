namespace DiscGolf
{
    public class DistanceDriver : Disc
    {
        public override Stability Stability { get; set; }

        public DistanceDriver(string name, decimal speed, Stability stability, PlasticType plastic) : base(name, DiscType.DistanceDriver, speed, plastic)
        {
            Stability = stability;
        }
    }
}