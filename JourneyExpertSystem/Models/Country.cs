namespace JourneyExpertSystem.Models
{
    internal class Country
    {
        internal string Name { get; set; }
        internal string Budget { get; set; }
        internal string RequiredVisa { get; set; }
        internal string Features { get; set; }

        internal Country(string name, string budget, string requiredVisa, string features)
        {
            Name = name;
            Budget = budget;
            RequiredVisa = requiredVisa;
            Features = features;
        }
    }
}
