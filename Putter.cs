namespace DiscGolf
{
    public class Putter : Disc
    {
        public override Stability Stability { get; set; }

        public Putter(string name, string discrange, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic)
            : base(name,discrange,DiscType.Putter, speed, glide, turn, fade, plastic)
        {
            Stability = stability;
        }
    }
}