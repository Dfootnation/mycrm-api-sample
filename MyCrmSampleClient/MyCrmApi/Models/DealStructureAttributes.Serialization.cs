// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace MyCrmSampleClient.MyCrmApi.Models
{
    public partial class DealStructureAttributes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LoanStructureType))
            {
                writer.WritePropertyName("loanStructureType");
                writer.WriteStringValue(LoanStructureType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DealStructureAttributes DeserializeDealStructureAttributes(JsonElement element)
        {
            Optional<DateTimeOffset?> fixedRateBeginDate = default;
            Optional<int?> rateTypePeriodMonths = default;
            Optional<DealStructureAttributesLoanStructureType> loanStructureType = default;
            Optional<double?> interestRate = default;
            Optional<double?> amount = default;
            Optional<string> rateType = default;
            Optional<double?> paymentAmount = default;
            Optional<DateTimeOffset?> interestOnlyExpiryDate = default;
            Optional<double?> loanTermYears = default;
            Optional<DateTimeOffset?> fixedRateExpiryDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fixedRateBeginDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fixedRateBeginDate = null;
                        continue;
                    }
                    fixedRateBeginDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("rateTypePeriodMonths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rateTypePeriodMonths = null;
                        continue;
                    }
                    rateTypePeriodMonths = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("loanStructureType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loanStructureType = new DealStructureAttributesLoanStructureType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("interestRate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        interestRate = null;
                        continue;
                    }
                    interestRate = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("amount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        amount = null;
                        continue;
                    }
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("rateType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rateType = null;
                        continue;
                    }
                    rateType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paymentAmount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        paymentAmount = null;
                        continue;
                    }
                    paymentAmount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("interestOnlyExpiryDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        interestOnlyExpiryDate = null;
                        continue;
                    }
                    interestOnlyExpiryDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("loanTermYears"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        loanTermYears = null;
                        continue;
                    }
                    loanTermYears = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("fixedRateExpiryDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fixedRateExpiryDate = null;
                        continue;
                    }
                    fixedRateExpiryDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
            }
            return new DealStructureAttributes(Optional.ToNullable(fixedRateBeginDate), Optional.ToNullable(rateTypePeriodMonths), Optional.ToNullable(loanStructureType), Optional.ToNullable(interestRate), Optional.ToNullable(amount), rateType.Value, Optional.ToNullable(paymentAmount), Optional.ToNullable(interestOnlyExpiryDate), Optional.ToNullable(loanTermYears), Optional.ToNullable(fixedRateExpiryDate));
        }
    }
}