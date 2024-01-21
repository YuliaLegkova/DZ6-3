using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6_3
{
            class Planet(string name, int number, int equatorLength, Planet? previousPlanet)
            {
            public string Name { get; } = name;
            public int Number { get; } = number;
            public int EquatorLength { get; } = equatorLength;
            public Planet PreviousPlanet { get; } = previousPlanet;
            }
}