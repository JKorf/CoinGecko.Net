﻿using System;
using System.Diagnostics;

namespace CoinGecko.Net.UnitTests
{
    internal class EnumValueTraceListener : TraceListener
    {
        public override void Write(string message)
        {
            if (message.Contains("Cannot map"))
                throw new Exception("Enum value error: " + message);
        }

        public override void WriteLine(string message)
        {
            if (message.Contains("Cannot map"))
                throw new Exception("Enum value error: " + message);
        }
    }
}
