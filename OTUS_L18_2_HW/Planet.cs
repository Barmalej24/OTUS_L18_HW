namespace OTUS_L18_2_HW
{
    internal class Planet
    {
        public Planet(ushort position, string name, double equator, Planet? previous)
        {
            Position = position;
            Name = name;
            Equator = equator;
            Previous = previous;
        }

        public ushort Position { get; }
        public string Name { get; }
        public double Equator { get; }
        public Planet? Previous { get; }
    }
}
