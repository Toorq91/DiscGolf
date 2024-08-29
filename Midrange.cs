namespace DiscGolf
{
    public class Midrange : Disc
    {
        public override Stability Stability { get; set; }

        public Midrange(string name, string discrange, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic)
            : base(name, discrange, DiscType.Midrange, speed, glide, turn, fade, plastic)
        {
            Stability = stability;
        }
    }
}