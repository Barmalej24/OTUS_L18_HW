namespace OTUS_L18_2_HW
{
    internal class CatalogPlanets
    {
        public CatalogPlanets()
        {
            var p1 = new Planet(2, "Венера", 12103.6, null);
            var p2 = new Planet(3, "Земля", 12742, p1);
            var p3 = new Planet(4, "Марс", 6780, p2);

            _planets = new List<Planet>() {p1,p2,p3};
        }
        private List<Planet> _planets { get; }

        private byte _count;
        public (ushort? position, double? equator, string? err) GetPlanet(string namePlanet)
        {
            _count++;

            var infoPlanet = _planets.Where(i => i.Name == namePlanet)
                .Select(i => new
                {
                    pos = i.Position,
                    equ = i.Equator,
                }
                ).ToList();

            if (infoPlanet.Count == 0)
                return (null, null, "Не удалось найти планету");

            if (_count % 3 == 0)
                return (infoPlanet[0].pos, infoPlanet[0].equ, "Вы спрашиваете слишком часто");

            return (infoPlanet[0].pos, infoPlanet[0].equ, null);

        }
    }
}
