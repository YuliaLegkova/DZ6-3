using Dz6_3;
using System.Security.Cryptography.X509Certificates;

using System;
using System.Collections.Generic;
using System.Numerics;
namespace Dz6_3
{
    internal class Program
    {
        static void Main()
        {
        
            CatalogPlanets catalog = new CatalogPlanets();

            PlanetValidator planetValidator = (planetName) =>
                {
            if (catalog.Counter % 3 == 0)
                return "Вы спрашиваете слишком часто";
            return null;
        };

            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля",planetValidator));
            Console.WriteLine("Лимония имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Лимония", planetValidator));
            Console.WriteLine("Марс имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Марс", planetValidator));
            Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Венера", planetValidator));
            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля", planetValidator));
            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля", planetValidator));
            Console.WriteLine("Лимония имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Лимония", planetValidator));
            Console.WriteLine("Марс имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Марс", planetValidator));
            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля", planetValidator));
            Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Венера", planetValidator));

        }
     }
    public delegate string? PlanetValidator(string planetName); 

}
