﻿// Copyright (c) Matt Lacey Ltd. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.Text;
using RapidXamlToolkit.Logging;
using RapidXamlToolkit.XamlAnalysis;
using RapidXamlToolkit.XamlAnalysis.Processors;

namespace RapidXamlToolkit.Tests.XamlAnalysis
{
    public class TestableXamlElementProcessor : XamlElementProcessor
    {
        public TestableXamlElementProcessor(ProcessorEssentials deps)
            : base(deps)
        {
        }

        public override void Process(string fileName, int offset, string xamlElement, string linePadding, ITextSnapshot snapshot, TagList tags, List<TagSuppression> suppressions = null)
        {
            Assert.Fail("This is not testable");
        }
    }
}
