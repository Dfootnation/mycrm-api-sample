// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class DealStructureImportantDatesDocumentLinks
    {
        internal static DealStructureImportantDatesDocumentLinks DeserializeDealStructureImportantDatesDocumentLinks(JsonElement element)
        {
            Optional<string> self = default;
            Optional<string> related = default;
            Optional<string> describedby = default;
            Optional<string> first = default;
            Optional<string> last = default;
            Optional<string> prev = default;
            Optional<string> next = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("self"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        self = null;
                        continue;
                    }
                    self = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("related"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        related = null;
                        continue;
                    }
                    related = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("describedby"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        describedby = null;
                        continue;
                    }
                    describedby = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("first"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        first = null;
                        continue;
                    }
                    first = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("last"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        last = null;
                        continue;
                    }
                    last = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prev"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        prev = null;
                        continue;
                    }
                    prev = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("next"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        next = null;
                        continue;
                    }
                    next = property.Value.GetString();
                    continue;
                }
            }
            return new DealStructureImportantDatesDocumentLinks(self.Value, related.Value, describedby.Value, first.Value, last.Value, prev.Value, next.Value);
        }
    }
}
