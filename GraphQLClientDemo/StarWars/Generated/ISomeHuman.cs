using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace GraphQLClientDemo
{
    public interface ISomeHuman
        : IHasName
    {
        string HomePlanet { get; }
    }
}
