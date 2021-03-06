﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

namespace CommandLine.Tests.Fakes
{
    public class FakeOptionWithRequiredAndSet {
        [Option("ftpurl", SetName = "SetA", Required = true)]
        public string FtpUrl { get; set; }

        [Option("weburl", SetName = "SetA",  Required = true)]
        public string WebUrl { get; set; }
    }
}