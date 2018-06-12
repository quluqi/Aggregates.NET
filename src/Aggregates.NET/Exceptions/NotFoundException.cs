﻿using System;
using System.Net;

namespace Aggregates.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() { }
        public NotFoundException(string stream, IPAddress client) : base($"Stream[{stream}] does not exist on {client}") { }
    }
}
