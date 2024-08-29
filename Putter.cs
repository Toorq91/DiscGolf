namespace DiscGolf
{
    public class Putter : Disc
    {
        public override Stability Stability { get; set; }

        public Putter(string name, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic) : base(name, DiscType.Putter, speed, glide, turn, fade, plastic)
        {
            Stability = stability;
        }
    }
}