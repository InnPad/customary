﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom.Data
{
    using Raven.Abstractions.Data;
    using Raven.Client;

    public static class DocumentStoreExtensions
    {
        public static List<JsonDocument> StartWith(this IDocumentStore store, string keyPrefix, Comparison<JsonDocument> comparison)
        {
            const int pageSize = 400;

            var result = new List<JsonDocument>();

            for (int start = 0, count = pageSize; count == pageSize; start = count)
            {
                var documents = store.DatabaseCommands.StartsWith(keyPrefix, null, start, pageSize);

                if (comparison != null)
                {
                    Array.Sort(documents, comparison);
                }

                result.AddRange(documents);

                count = documents.Length;
            }

            if (comparison != null)
            {
                result.Sort(comparison);
            }

            return result;
        }
    }
}