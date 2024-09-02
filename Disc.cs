namespace DiscGolf
{
    public class Disc : IDisc
    {
        private string _name;
        private string _discrange;
        private DiscType _type;
        private decimal _speed;
        private decimal _glide;
        private decimal _turn;
        private decimal _fade;
        private PlasticType _plastic;
        private Stability _stability;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string DiscRange
        {
            get { return _discrange; }
            set { _discrange = value; }
        }

        public DiscType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public decimal Speed
        {
            get { return _speed; }
            set
            {
                if (value >= 0)
                    _speed = value;
            }
        }

        public decimal Glide
        {
            get { return _glide; }
            set
            {
                if (value >= 0)
                    _glide = value;
            }
        }

        public decimal Turn
        {
            get { return _turn; }
            set { _turn = value; }
        }

        public decimal Fade
        {
            get { return _fade; }
            set
            {
                if (value >= 0)
                    _fade = value;
            }
        }

        public PlasticType Plastic
        {
            get { return _plastic; }
            set { _plastic = value; }
        }

        public Stability Stability
        {
            get { return _stability; }
            set { _stability = value; }
        }

        public Disc(string name, string discrange, DiscType type, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic)
        {
            Name = name;
            DiscRange = discrange;
            Type = type;
            Speed = speed;
            Glide = glide;
            Turn = turn;
            Fade = fade;
            Stability = Stability;
            Plastic = plastic;

            DiscRange = FormatDiscRange(discrange);
        }

        private string FormatDiscRange(string discrange)
        {
            return string.Concat(discrange.Select((x, i) => i > 0 && char.IsUpper(x) ? " " + char.ToLower(x) : char.ToLower(x).ToString()));
        }

        public void Flight()
        {
            string flightDescription = FlightDescription.GetFlightDescription(Name, DiscRange, Speed, Glide, Turn, Fade, Stability, Plastic);
            Console.WriteLine(flightDescription);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Speed: {Speed}, Glide: {Glide}, Turn: {Turn}, Fade: {Fade}, Plastic: {Plastic}");
        }
    }
}