﻿#region License
// 
//     MIT License
//
//     CoiniumServ - Crypto Currency Mining Pool Server Software
//     Copyright (C) 2013 - 2017, CoiniumServ Project
//     Hüseyin Uslu, shalafiraistlin at gmail dot com
//     https://github.com/bonesoul/CoiniumServ
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
// 
#endregion

using System.Collections.Generic;
using HashLib;

namespace CoiniumServ.Algorithms.Implementations
{
	// anorganix start
	// added PHI1612 support (BHCoin)
	// anorganix end
    public sealed class PHI1612 : IHashAlgorithm
    {
        public uint Multiplier { get; private set; }

        private readonly List<IHash> _hashers;

		public PHI1612()
        {
            _hashers = new List<IHash>
            {
                HashFactory.Crypto.SHA3.CreateSkein512(),
                HashFactory.Crypto.SHA3.CreateJH512(),
				HashFactory.Crypto.SHA3.CreateCubeHash512(),
				HashFactory.Crypto.SHA3.CreateFugue512(),
				HashFactory.Crypto.CreateGost(),
				HashFactory.Crypto.SHA3.CreateEcho512()
            };

            Multiplier = 1;
        }

        public byte[] Hash(byte[] input)
        {
            var buffer = input;

            foreach (var hasher in _hashers)
            {
                buffer = hasher.ComputeBytes(buffer).GetBytes();
            }

            return buffer;
        }
    }
}
