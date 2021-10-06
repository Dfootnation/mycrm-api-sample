// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class AdviserAddressAttributes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static AdviserAddressAttributes DeserializeAdviserAddressAttributes(JsonElement element)
        {
            Optional<bool?> isMailing = default;
            Optional<bool?> isBusiness = default;
            Optional<string> streetAddress = default;
            Optional<string> country = default;
            Optional<string> suburb = default;
            Optional<string> postCode = default;
            Optional<string> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isMailing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isMailing = null;
                        continue;
                    }
                    isMailing = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isBusiness"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isBusiness = null;
                        continue;
                    }
                    isBusiness = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("streetAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        streetAddress = null;
                        continue;
                    }
                    streetAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        country = null;
                        continue;
                    }
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suburb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        suburb = null;
                        continue;
                    }
                    suburb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        postCode = null;
                        continue;
                    }
                    postCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        state = null;
                        continue;
                    }
                    state = property.Value.GetString();
                    continue;
                }
            }
            return new AdviserAddressAttributes(Optional.ToNullable(isMailing), Optional.ToNullable(isBusiness), streetAddress.Value, country.Value, suburb.Value, postCode.Value, state.Value);
        }
    }
}