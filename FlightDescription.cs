namespace DiscGolf
{
    public static class FlightDescription
    {
        public static string GetFlightDescription(string name, string discrange, decimal speed, decimal glide, decimal turn, decimal fade, Stability stability, PlasticType plastic)
        {
            string flightDescription = stability switch
            {
                    Stability.Overstable =>
                        $"{name} is an overstable {discrange} designed to fade left at the end of the flight.",
                    Stability.Stable =>
                        $"{name} is a stable {discrange} designed to fly straight with minimal fade.",
                    Stability.Understable =>
                        $"{name} is an understable {discrange} designed to turn right before fading.",
                    Stability.Flippy =>
                        $"{name} is a very understable {discrange} designed to really turn over to the right and hold that line.",
                    Stability.Tomahawk =>
                        $"{name} is an extremely understable {discrange} and can be used to throw a tomahawk shot.",
                    _ => $"{name} has an unknown flight characteristic."
            };

            flightDescription += "\n" + PlasticTypeExtensions.GetFlightDescription(plastic);

            return flightDescription;
        }
    }
}
