﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom.Metadata
{
    using Custom.Documents;

    public class MeasureDescriptor : TypeDescriptor
    {
        public string BaseQuantity { get; set; }
    }
}