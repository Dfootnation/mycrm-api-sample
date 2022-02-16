// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class ExpenseCategoryRelationships : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpenseTypes))
            {
                writer.WritePropertyName("expenseTypes");
                writer.WriteObjectValue(ExpenseTypes);
            }
            writer.WriteEndObject();
        }

        internal static ExpenseCategoryRelationships DeserializeExpenseCategoryRelationships(JsonElement element)
        {
            Optional<RelationshipsMultipleDocument> expenseTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expenseTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expenseTypes = RelationshipsMultipleDocument.DeserializeRelationshipsMultipleDocument(property.Value);
                    continue;
                }
            }
            return new ExpenseCategoryRelationships(expenseTypes.Value);
        }
    }
}
