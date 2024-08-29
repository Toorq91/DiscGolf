namespace DiscGolf
{
    public class DistanceDriver : Disc
    {
        public override Stability Stability { get; set; }

        public DistanceDriver(string name, string discrange, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic)
            : base(name, discrange, DiscType.DistanceDriver, speed, glide, turn, fade, plastic)
        {
            Stability = stability;
        }
    }
}