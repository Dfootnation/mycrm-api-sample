// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class AdviserDetailRelationships : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Adviser))
            {
                writer.WritePropertyName("adviser");
                writer.WriteObjectValue(Adviser);
            }
            writer.WriteEndObject();
        }

        internal static AdviserDetailRelationships DeserializeAdviserDetailRelationships(JsonElement element)
        {
            Optional<RelationshipsSingleDocument> adviser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adviser"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    adviser = RelationshipsSingleDocument.DeserializeRelationshipsSingleDocument(property.Value);
                    continue;
                }
            }
            return new AdviserDetailRelationships(adviser.Value);
        }
    }
}
