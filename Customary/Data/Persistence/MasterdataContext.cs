﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom.Data.Persistence
{
    using Custom.Data.Metadata;
    using Raven.Client;
    using Raven.Client.Embedded;

    public class MasterdataContext : DocumentContext
    {
        public MasterdataContext()
            : base("Masterdata")
        {
        }

        protected override IDocumentStore CreateDocumentStore()
        {
            return new EmbeddableDocumentStore
            {
                ConnectionStringName = Name
            };
        }
    }
}