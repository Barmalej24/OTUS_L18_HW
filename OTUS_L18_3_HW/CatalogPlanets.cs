namespace OTUS_L18_3_HW
{
    internal class CatalogPlanets
    {
        private readonly List<Planet> _planets;
        public CatalogPlanets()
        {
            var p1 = new Planet(2, "Венера", 12103.6, null);
            var p2 = new Planet(3, "Земля", 12742, p1);
            var p3 = new Planet(4, "Марс", 6780, p2);

            _planets = new List<Planet>() {p1,p2,p3};
        }        

        public (ushort? position, double? equator, string? err) GetPlanet(string namePlanet, Func<string, string> planetValidator)
        {

            var infoPlanet = _planets.Where(i => i.Name == namePlanet)
                .Select(i => new
                {
                    pos = i.Position,
                    equ = i.Equator,
                }
                ).ToList();

            if (infoPlanet.Count == 0)
            {
                return (null, null, planetValidator(namePlanet) ?? "Не удалось найти планету");
            }

            return (infoPlanet[0].pos, infoPlanet[0].equ, planetValidator(namePlanet));

        }
    }
}
