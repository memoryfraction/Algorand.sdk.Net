﻿using System.Text.Json.Serialization;

namespace Algorand.SDK.Dotnet.Api.Models
{
    public class Curxfer
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("amt")]
        public long Amt { get; set; }

        [JsonPropertyName("snd")]
        public string Snd { get; set; }

        [JsonPropertyName("rcv")]
        public string Rcv { get; set; }

        [JsonPropertyName("closeto")]
        public string Closeto { get; set; }
    }
}