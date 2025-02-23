﻿using System.Text.Json.Serialization;

namespace Algorand.SDK.Dotnet.Api.Models
{
    public class TotalSupply
    {
        [JsonPropertyName("round")]
        public int Round { get; set; }

        [JsonPropertyName("totalMoney")]
        public long TotalMoney { get; set; }

        [JsonPropertyName("onlineMoney")]
        public long OnlineMoney { get; set; }
    }
}