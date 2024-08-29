namespace DiscGolf
{
    public class Midrange : Disc
    {
        public override Stability Stability { get; set; }

        public Midrange(string name, decimal speed, Stability stability, PlasticType plastic) : base(name, DiscType.Midrange, speed, plastic)
        {
            Stability = stability;
        }
    }
}