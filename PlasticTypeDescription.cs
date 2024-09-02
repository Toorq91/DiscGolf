namespace DiscGolf
{
    public static class PlasticTypeExtensions
    {
        public static string GetFlightDescription(this PlasticType plastic)
        {
            return plastic switch
            {
                PlasticType.Electron => "The electron plastic comes in 3 different stiffness: (Soft, firm, and hard) and has a rough texture for nice grip.",
                PlasticType.Fission => "The fission plastic is a bit softer than other molds and is usually lighter weight and therefor is a bit easier to get the disc to turn.",
                PlasticType.Neutron => "The neutron plastic has a nice grippy and hard surface and is designed to go straight with a nice fade at the end.",
                PlasticType.Champion => "The champion plastic is a hard see-through plastic that usually makes the discs a lot more overstable.",
                PlasticType.Star => "The star plastic is a medium stiffness mold and is nice and grippy.",
                PlasticType.Gold => "The gold plastic is a bit softer mold and is gives a comfortable grip",
                PlasticType.Opto => "The opto plastic is softer see-through mold and gives a comfortable grip",
                _ => "Unknown plastic type."
            };
        }
    }
}
