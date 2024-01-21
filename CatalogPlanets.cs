using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Dz6_3
{
    class CatalogPlanets
    {
        private List<Planet> planets;
        private int count = 0;
        public CatalogPlanets()
        {
            Planet? previousPlanet = null;
            planets = new List<Planet>
            {
                new Planet("Венера", 2, 38052, previousPlanet:previousPlanet),
                new Planet("Земля", 3, 40075, previousPlanet:previousPlanet),
                new Planet("Марс", 4, 21165, previousPlanet:previousPlanet)
            };
        }
        public int GetCount()
        {
            return count;
        }
        public (int?, int?, string?) GetPlanet(string name, PlanetValidator planetValidator)
        {
            count++;
            foreach (var planet in planets)
            {
                if (planet.Name == name)
                { string? error = planetValidator(name);
                    return (planet.Number, planet.EquatorLength, error);
                }
            }
            return (null, null, "Не удалось найти планету");
        }
    }
}
