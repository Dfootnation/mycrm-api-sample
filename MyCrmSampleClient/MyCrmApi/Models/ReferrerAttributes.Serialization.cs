// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class ReferrerAttributes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ReferrerName))
            {
                if (ReferrerName != null)
                {
                    writer.WritePropertyName("referrerName");
                    writer.WriteStringValue(ReferrerName);
                }
                else
                {
                    writer.WriteNull("referrerName");
                }
            }
            writer.WriteEndObject();
        }

        internal static ReferrerAttributes DeserializeReferrerAttributes(JsonElement element)
        {
            Optional<string> referrerName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referrerName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        referrerName = null;
                        continue;
                    }
                    referrerName = property.Value.GetString();
                    continue;
                }
            }
            return new ReferrerAttributes(referrerName.Value);
        }
    }
}
