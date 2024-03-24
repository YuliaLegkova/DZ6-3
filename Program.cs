  namespace Dz6_3
{
    internal class Program
    {
        static void Main()

        {
            int callCounter = 0;
            CatalogPlanets catalog = new CatalogPlanets();
            PlanetValidator frequencyCallAndTabooValidator = (string planetName) =>
            {
                callCounter++;

                if (callCounter % 3 == 0)
                {
                    return "Вы спрашиваете слишком часто";
                }

                if (planetName == "Лимония")
                {
                    return "Это запретная планета";
                }
                return null;
            };
            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля", frequencyCallAndTabooValidator));
            Console.WriteLine("Лимония имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Лимония", frequencyCallAndTabooValidator));
            Console.WriteLine("Марс имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Марс", frequencyCallAndTabooValidator));
            Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Венера", frequencyCallAndTabooValidator));
            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля", frequencyCallAndTabooValidator));
            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля", frequencyCallAndTabooValidator));
            Console.WriteLine("Лимония имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Лимония", frequencyCallAndTabooValidator));
            Console.WriteLine("Марс имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Марс", frequencyCallAndTabooValidator));
            Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Земля", frequencyCallAndTabooValidator));
            Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Венера", frequencyCallAndTabooValidator));
            Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Венера", frequencyCallAndTabooValidator));
            Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Венера", frequencyCallAndTabooValidator));
            Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Венера", frequencyCallAndTabooValidator));
            Console.WriteLine("Луна имеет порядковый номер от Солнца и длину экватора: " + catalog.GetPlanet("Луна", frequencyCallAndTabooValidator));
        }
    }
}
