﻿// Copyright (c) Matt Lacey Ltd. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using RapidXamlToolkit.Resources;

namespace RapidXamlToolkit.XamlAnalysis.Processors
{
    public class AppBarButtonProcessor : XamlElementProcessor
    {
        public AppBarButtonProcessor(ProcessorEssentials essentials)
            : base(essentials)
        {
        }

        public override void Process(string fileName, int offset, string xamlElement, string linePadding, IRapidXamlTextSnapshot snapshot, TagList tags, List<TagSuppression> suppressions = null)
        {
            if (!this.ProjectType.Matches(ProjectType.Uwp))
            {
                return;
            }

            var (uidExists, uid) = this.GetOrGenerateUid(xamlElement, Attributes.Label);

            this.CheckForHardCodedAttribute(
                fileName,
                Elements.AppBarButton,
                Attributes.Label,
                AttributeType.InlineOrElement,
                StringRes.UI_XamlAnalysisHardcodedStringAppBarButtonLabelMessage,
                xamlElement,
                snapshot,
                offset,
                uidExists,
                uid,
                Guid.Empty,
                tags,
                suppressions,
                this.ProjectType);
        }
    }
}
