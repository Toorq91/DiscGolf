namespace DiscGolf
{

    public class FairwayDriver : Disc
    {
        public override Stability Stability { get; set; }

        public FairwayDriver(string name, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic) : base(name, DiscType.FairwayDriver, speed, glide, turn, fade, plastic)
        {
            Stability = stability;
        }
    }
}