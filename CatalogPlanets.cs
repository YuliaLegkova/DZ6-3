using Dz6_3;
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
        public int Counter { get; set; }
        public CatalogPlanets()
        {
            
            planets = new List<Planet>
            {
                new Planet("Венера", 2, 38052),
                new Planet("Земля", 3, 40075),
                new Planet("Марс", 4, 21165)
            };
        }
        
        public (int?, int?, string?) GetPlanet(string name, PlanetValidator planetValidator)
        {
            Counter++;
            foreach (var planet in planets)
            {
                if (planet.Name == name)
                {
                    string? planetValidationError = planetValidator(name);
                    if (planetValidationError != null)
                        return (null, null, planetValidationError);

                    return (planet.Number, planet.EquatorLength, null);

                    }
            }
            return (null, null, "Не удалось найти планету");
        }
    }
}
