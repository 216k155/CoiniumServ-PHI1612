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

using CoiniumServ.Configuration;
using Serilog.Events;

namespace CoiniumServ.Logging
{
    public interface ILogTarget: IConfig
    {
        bool Enabled { get; }

        /// <summary>
        /// console, file or packet.
        /// </summary>
        LogTargetType Type { get; }

        /// <summary>
        /// filename of the log file.
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// set this true to get a seperate log file for every day.
        /// </summary>
        bool Rolling { get; }

        /// <summary>
        /// minimum log level.
        /// </summary>
        LogEventLevel Level { get; }
    }

    public enum LogTargetType
    {
        /// <summary>
        /// Logs to a file.
        /// </summary>
        File,
        /// <summary>
        /// Logs network packets to a file.
        /// </summary>
        Packet
    }
}
