using System.Security.Cryptography.X509Certificates;

namespace DiscGolf
{
    public static class FlightDescription
    {
        public static string GetFlightDescription(string name, decimal speed, Stability stability, PlasticType plastic)
        {
            string stabilityDescription = stability switch
            {

                Stability.Overstable =>
                    $"{name} is an overstable putter with {speed} speed, designed to fade left at the end of the flight.\n",
                Stability.Stable =>
                    $"{name} is a stable putter with {speed} speed, designed to fly straight with minimal fade.\n",
                Stability.Understable =>
                    $"{name} is an understable putter with {speed} speed, designed to turn right before fading.\n",
                _ => $"{name} has an unknown flight characteristic."
            };

            string plasticDescription = plastic.GetFlightDescription();

            return $"{stabilityDescription}{plasticDescription}";
        }
    }
}
