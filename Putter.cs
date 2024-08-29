namespace DiscGolf
{
    public class Putter : Disc
    {
        public override Stability Stability { get; set; }

        public Putter(string name, decimal speed, Stability stability, PlasticType plastic) : base(name, DiscType.Putter, speed, plastic)
        {
            Stability = stability;
        }
    }
}