namespace DiscGolf
{
    public static class FlightDescription
    {
        public static string GetFlightDescription(string name, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic)
        {
            string flightDescription = stability switch
            {

                Stability.Overstable =>
                    $"{name} is an overstable putter designed to fade left at the end of the flight.",
                Stability.Stable =>
                    $"{name} is a stable putter designed to fly straight with minimal fade.",
                Stability.Understable =>
                    $"{name} is an understable putter designed to turn right before fading.",
                _ => $"{name} has an unknown flight characteristic."
            };

            flightDescription += "\n" + PlasticTypeExtensions.GetFlightDescription(plastic);

            return flightDescription;
        }
    }
}
