
namespace Dz6_3
{
    internal class CatalogPlanets
    {
        private readonly List<Planet> planets;
        private static int callCounter = 0;
        public CatalogPlanets()
        {
            planets = new List<Planet>();
            var venus = new Planet("Венера", 2, 38052, null);
            var earth = new Planet("Земля", 3, 40075, venus);
            var mars = new Planet("Марс", 4, 21165, earth);
            planets.Add(venus);
            planets.Add(earth);
            planets.Add(mars);
        }
        public (int? Number, int? EquatorLength, string? ErrorMessage) GetPlanet(string name, PlanetValidator validator)
        {
            callCounter++;
            var errorMessage = validator(name);
            if (errorMessage != null)
            {
                return (null, null, errorMessage);
            }
            foreach (var planet in planets)
            {
                if (planet.Name == name)
                {
                    return (planet.Number, planet.EquatorLength, null);
                }
            }
            
            return (null, null, "Не удалось найти планету");
        }
    }
}

