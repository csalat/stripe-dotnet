﻿namespace Stripe
{
    using Newtonsoft.Json;

    public class BalanceTransactionListOptions : ListOptions
    {
        [JsonProperty("available_on")]
        public DateFilter AvailableOn { get; set; }

        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payout")]
        public string PayoutId { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}