// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class IncomeRelationships : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedAsset))
            {
                writer.WritePropertyName("linkedAsset");
                writer.WriteObjectValue(LinkedAsset);
            }
            if (Optional.IsDefined(Ownership))
            {
                writer.WritePropertyName("ownership");
                writer.WriteObjectValue(Ownership);
            }
            writer.WriteEndObject();
        }

        internal static IncomeRelationships DeserializeIncomeRelationships(JsonElement element)
        {
            Optional<RelationshipsSingleDocument> linkedAsset = default;
            Optional<RelationshipsMultipleDocument> ownership = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedAsset"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkedAsset = RelationshipsSingleDocument.DeserializeRelationshipsSingleDocument(property.Value);
                    continue;
                }
                if (property.NameEquals("ownership"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ownership = RelationshipsMultipleDocument.DeserializeRelationshipsMultipleDocument(property.Value);
                    continue;
                }
            }
            return new IncomeRelationships(linkedAsset.Value, ownership.Value);
        }
    }
}
