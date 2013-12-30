﻿using Lostics.NCryptoExchange.Cryptsy;
using System;
using System.IO;

namespace Lostics.NCryptoExchangeExamples.Cryptsy
{
    public abstract class AbstractCryptsyExample
    {
        public const string CONFIG_FILENAME = "cryptsy.conf";

        public static FileInfo GetDefaultConfigurationFile()
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent;
            return new FileInfo(Path.Combine(dir.FullName, CONFIG_FILENAME));
        }

        public static CryptsyExchange GetExchange()
        {
            return Lostics.NCryptoExchange.Cryptsy.CryptsyExchange.GetExchange(GetDefaultConfigurationFile());
        }
    }
}
