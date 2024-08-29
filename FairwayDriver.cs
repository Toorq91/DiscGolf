namespace DiscGolf
{

    public class FairwayDriver : Disc
    {
        public override Stability Stability { get; set; }

        public FairwayDriver(string name, decimal speed, Stability stability, PlasticType plastic) : base(name, DiscType.FairwayDriver, speed, plastic)
        {
            Stability = stability;
        }
    }
}