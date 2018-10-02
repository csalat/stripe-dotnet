namespace Stripe.Reporting
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Parameters : StripeEntity
    {
        [JsonProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval_end")]
        public DateTime IntervalEnd { get; set; }

        [JsonProperty("interval_start")]
        public DateTime IntervalStart { get; set; }

        [JsonProperty("payout")]
        public string Payout { get; set; }

        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }
    }
}
