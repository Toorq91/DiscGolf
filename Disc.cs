namespace DiscGolf
{
    public abstract class Disc : IDisc
    {
        private string _name;
        private DiscType _type;
        private decimal _speed;
        private decimal _glide;
        private decimal _turn;
        private decimal _fade;
        private PlasticType _plastic;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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

        public Disc(string name, DiscType type, decimal speed, decimal glide, decimal turn, decimal fade, PlasticType plastic)
        {
            Name = name;
            Type = type;
            Speed = speed;
            Glide = glide;
            Turn = turn;
            Fade = fade;
            Plastic = plastic;
        }

        public abstract Stability Stability { get; set; }

        public void Flight()
        {
            string flightDescription = FlightDescription.GetFlightDescription(Name, Speed, Glide, Turn, Fade, Stability, Plastic);
            Console.WriteLine(flightDescription);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Speed: {Speed}, Glide: {Glide}, Turn: {Turn}, Fade: {Fade}, Plastic: {Plastic}");
        }
    }
}