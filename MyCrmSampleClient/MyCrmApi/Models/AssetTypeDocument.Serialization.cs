// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class AssetTypeDocument
    {
        internal static AssetTypeDocument DeserializeAssetTypeDocument(JsonElement element)
        {
            Optional<IReadOnlyDictionary<string, object>> meta = default;
            Optional<IReadOnlyDictionary<string, object>> jsonApi = default;
            Optional<AssetTypeDocumentLinks> links = default;
            AssetType data = default;
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
                    links = AssetTypeDocumentLinks.DeserializeAssetTypeDocumentLinks(property.Value);
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    data = AssetType.DeserializeAssetType(property.Value);
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
            return new AssetTypeDocument(Optional.ToDictionary(meta), Optional.ToDictionary(jsonApi), links.Value, data, Optional.ToList(included));
        }
    }
}
