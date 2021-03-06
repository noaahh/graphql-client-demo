using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace GraphQLClientDemo
{
    public class Queries
        : IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            112,
            48,
            121,
            114,
            108,
            67,
            47,
            78,
            105,
            108,
            69,
            88,
            106,
            72,
            121,
            110,
            114,
            119,
            68,
            73,
            72,
            65,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            72,
            101,
            114,
            111,
            40,
            36,
            101,
            112,
            105,
            115,
            111,
            100,
            101,
            58,
            32,
            69,
            112,
            105,
            115,
            111,
            100,
            101,
            33,
            41,
            32,
            123,
            32,
            104,
            101,
            114,
            111,
            40,
            101,
            112,
            105,
            115,
            111,
            100,
            101,
            58,
            32,
            36,
            101,
            112,
            105,
            115,
            111,
            100,
            101,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            46,
            46,
            46,
            32,
            83,
            111,
            109,
            101,
            68,
            114,
            111,
            105,
            100,
            32,
            46,
            46,
            46,
            32,
            83,
            111,
            109,
            101,
            72,
            117,
            109,
            97,
            110,
            32,
            125,
            32,
            125,
            32,
            102,
            114,
            97,
            103,
            109,
            101,
            110,
            116,
            32,
            83,
            111,
            109,
            101,
            72,
            117,
            109,
            97,
            110,
            32,
            111,
            110,
            32,
            72,
            117,
            109,
            97,
            110,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            46,
            46,
            46,
            32,
            72,
            97,
            115,
            78,
            97,
            109,
            101,
            32,
            104,
            111,
            109,
            101,
            80,
            108,
            97,
            110,
            101,
            116,
            32,
            125,
            32,
            102,
            114,
            97,
            103,
            109,
            101,
            110,
            116,
            32,
            83,
            111,
            109,
            101,
            68,
            114,
            111,
            105,
            100,
            32,
            111,
            110,
            32,
            68,
            114,
            111,
            105,
            100,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            46,
            46,
            46,
            32,
            72,
            97,
            115,
            78,
            97,
            109,
            101,
            32,
            112,
            114,
            105,
            109,
            97,
            114,
            121,
            70,
            117,
            110,
            99,
            116,
            105,
            111,
            110,
            32,
            125,
            32,
            102,
            114,
            97,
            103,
            109,
            101,
            110,
            116,
            32,
            72,
            97,
            115,
            78,
            97,
            109,
            101,
            32,
            111,
            110,
            32,
            67,
            104,
            97,
            114,
            97,
            99,
            116,
            101,
            114,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query getHero($episode: Episode!) {
              hero(episode: $episode) {
                ... SomeDroid
                ... SomeHuman
              }
            }
            
            fragment SomeHuman on Human {
              ... HasName
              homePlanet
            }
            
            fragment SomeDroid on Droid {
              ... HasName
              primaryFunction
            }
            
            fragment HasName on Character {
              name
            }";
    }
}
