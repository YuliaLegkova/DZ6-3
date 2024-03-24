using System.Numerics;

namespace Dz6_3
{
    internal delegate string PlanetValidator(string planetName);
        internal class Planet(string name, int number, int equatorLength, Planet previousPlanet)

    {
        public string Name { get; } = name;
        public int Number { get; } = number;
        public int EquatorLength { get; } = equatorLength;
        public Planet? PreviousPlanet { get; } = previousPlanet;
    }

}

