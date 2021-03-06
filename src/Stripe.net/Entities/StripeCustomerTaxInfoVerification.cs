namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeCustomerTaxInfoVerification : StripeEntity
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}