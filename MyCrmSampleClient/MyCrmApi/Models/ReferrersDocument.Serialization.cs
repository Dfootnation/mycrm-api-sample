// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class ReferrersDocument
    {
        internal static ReferrersDocument DeserializeReferrersDocument(JsonElement element)
        {
            Optional<IReadOnlyDictionary<string, object>> meta = default;
            Optional<IReadOnlyDictionary<string, object>> jsonApi = default;
            Optional<ReferrersDocumentLinks> links = default;
            IReadOnlyList<Referrer> data = default;
            Optional<IReadOnlyList<IncludedResource>> included = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meta"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    meta = dictionary;
                    continue;
                }
                if (property.NameEquals("jsonApi"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    jsonApi = dictionary;
                    continue;
                }
                if (property.NameEquals("links"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    links = ReferrersDocumentLinks.DeserializeReferrersDocumentLinks(property.Value);
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    List<Referrer> array = new List<Referrer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Referrer.DeserializeReferrer(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("included"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        included = null;
                        continue;
                    }
                    List<IncludedResource> array = new List<IncludedResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IncludedResource.DeserializeIncludedResource(item));
                    }
                    included = array;
                    continue;
                }
            }
            return new ReferrersDocument(Optional.ToDictionary(meta), Optional.ToDictionary(jsonApi), links.Value, data, Optional.ToList(included));
        }
    }
}
