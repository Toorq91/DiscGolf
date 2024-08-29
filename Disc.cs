namespace DiscGolf
{
    public abstract class Disc : IDisc
    {
        private string _name;
        private DiscType _type;
        private decimal _speed;
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

        public PlasticType Plastic
        {
            get { return _plastic; }
            set { _plastic = value; }
        }

        public Disc(string name, DiscType type, decimal speed, PlasticType plastic)
        {
            Name = name;
            Type = type;
            Speed = speed;
            Plastic = plastic;
        }

        public abstract Stability Stability { get; set; }

        public void Flight()
        {
            string flightDescription = FlightDescription.GetFlightDescription(Name, Speed, Stability, Plastic);
            Console.WriteLine(flightDescription);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Speed: {Speed}, Plastic: {Plastic}");
        }
    }
}