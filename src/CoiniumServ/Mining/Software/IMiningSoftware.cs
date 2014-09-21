﻿#region License
// 
//     CoiniumServ - Crypto Currency Mining Pool Server Software
//     Copyright (C) 2013 - 2014, CoiniumServ Project - http://www.coinium.org
//     http://www.coiniumserv.com - https://github.com/CoiniumServ/CoiniumServ
// 
//     This software is dual-licensed: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
//    
//     For the terms of this license, see licenses/gpl_v3.txt.
// 
//     Alternatively, you can license this software under a commercial
//     license or white-label it as set out in licenses/commercial.txt.
// 
#endregion

using System;
using System.Collections.Generic;
using CoiniumServ.Algorithms;

namespace CoiniumServ.Mining.Software
{
    public interface IMiningSoftware
    {
        string Name { get; }

        Version Version { get; }

        IList<IHashAlgorithm> Algorithms { get; }

        Platforms Platforms { get; }

        string Site { get; }

        IDictionary<string, string> Downloads { get; }
    }

    [Flags]
    public enum Platforms
    {
        Cpu = 1,
        Ati = 2,
        Nvidia = 4,
        Asic = 8
    }
}
