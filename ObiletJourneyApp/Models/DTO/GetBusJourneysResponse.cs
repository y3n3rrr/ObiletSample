using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ObiletJourneyApp.Models.DTO
{
    public class Datum
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("partner-id")]
        public int PartnerId { get; set; }

        [JsonPropertyName("partner-name")]
        public string? PartnerName { get; set; }

        [JsonPropertyName("route-id")]
        public int RouteId { get; set; }

        [JsonPropertyName("bus-type")]
        public string? BusType { get; set; }

        [JsonPropertyName("bus-type-name")]
        public string? BusTypeName { get; set; }

        [JsonPropertyName("total-seats")]
        public int TotalSeats { get; set; }

        [JsonPropertyName("available-seats")]
        public int AvailableSeats { get; set; }

        public Journey? Journey { get; set; }
        public List<Feature>? Features { get; set; }

        [JsonPropertyName("origin-location")]
        public string? OriginLocation { get; set; }

        [JsonPropertyName("destination-location")]
        public string? DestinationLocation { get; set; }

        [JsonPropertyName("is-active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("origin-location-id")]
        public int OriginLocationId { get; set; }

        [JsonPropertyName("destination-location-id")]
        public int DestinationLocationId { get; set; }

        [JsonPropertyName("is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonPropertyName("cancellation-offset")]
        public int? CancellationOffset { get; set; }

        [JsonPropertyName("has-bus-shuttle")]
        public bool HasBusShuttle { get; set; }

        [JsonPropertyName("disable-sales-without-gov-id")]
        public bool DisableSalesWithoutGovId { get; set; }

        [JsonPropertyName("display-offset")]
        public string? DisplayOffset { get; set; }

        [JsonPropertyName("partner-rating")]
        public double? PartnerRating { get; set; }

        [JsonPropertyName("has-dynamic-pricing")]
        public bool HasDynamicPricing { get; set; }

        [JsonPropertyName("disable-sales-without-hes-code")]
        public bool DisableSalesWithoutHesCode { get; set; }

        [JsonPropertyName("disable-single-seat-selection")]
        public bool DisableSingleSeatSelection { get; set; }

        [JsonPropertyName("change-offset")]
        public int ChangeOffset { get; set; }

        public int Rank { get; set; }

        [JsonPropertyName("display-coupon-code-input")]
        public bool DisplayCouponCodeInput { get; set; }

        [JsonPropertyName("disable-sales-without-date-of-birth")]
        public bool DisableSalesWithoutDateOfBirth { get; set; }

        [JsonPropertyName("open-offset")]
        public int? OpenOffset { get; set; }

        [JsonPropertyName("display-buffer")]
        public object? DisplayBuffer { get; set; }

        [JsonPropertyName("allow-sales-foreign-passenger")]
        public bool AllowSalesForeignPassenger { get; set; }

        [JsonPropertyName("has-seat-selection")]
        public bool HasSeatSelection { get; set; }

        [JsonPropertyName("branded-fares")]
        public List<object> BrandedFares { get; set; } = new List<object>();

        [JsonPropertyName("has-gender-selection")]
        public bool HasGenderSelection { get; set; }

        [JsonPropertyName("has-dynamic-cancellation")]
        public bool HasDynamicCancellation { get; set; }

        [JsonPropertyName("partner-terms-and-conditions")]
        public object? PartnerTermsAndConditions { get; set; }

        [JsonPropertyName("partner-available-alphabets")]
        public string? PartnerAvailableAlphabets { get; set; }

        [JsonPropertyName("provider-id")]
        public int ProviderId { get; set; }

        [JsonPropertyName("partner-code")]
        public string? PartnerCode { get; set; }

        [JsonPropertyName("enable-full-journey-display")]
        public bool EnableFullJourneyDisplay { get; set; }

        [JsonPropertyName("provider-name")]
        public string? ProviderName { get; set; }

        [JsonPropertyName("enable-all-stops-display")]
        public bool EnableAllStopsDisplay { get; set; }

        [JsonPropertyName("is-destination-domestic")]
        public bool IsDestinationDomestic { get; set; }

        [JsonPropertyName("min-len-gov-id")]
        public object? MinLenGovId { get; set; }

        [JsonPropertyName("max-len-gov-id")]
        public object? MaxLenGovId { get; set; }

        [JsonPropertyName("require-foreign-gov-id")]
        public bool RequireForeignGovId { get; set; }

        [JsonPropertyName("is-cancellation-info-text")]
        public bool IsCancellationInfoText { get; set; }

        [JsonPropertyName("cancellation-offset-info-text")]
        public object? CancellationOffsetInfoText { get; set; }

        [JsonPropertyName("is-time-zone-not-equal")]
        public bool IsTimeZoneNotEqual { get; set; }

        [JsonPropertyName("markup-rate")]
        public double MarkupRate { get; set; }

        [JsonPropertyName("is-print-ticket-before-journey")]
        public bool IsPrintTicketBeforeJourney { get; set; }

        [JsonPropertyName("is-extended-journey-detail")]
        public bool IsExtendedJourneyDetail { get; set; }

        [JsonPropertyName("is-payment-select-gender")]
        public bool IsPaymentSelectGender { get; set; }

        [JsonPropertyName("should-turkey-on-the-nationality-list")]
        public bool ShouldTurkeyOnTheNationalityList { get; set; }

        [JsonPropertyName("markup-fee")]
        public double MarkupFee { get; set; }

        [JsonPropertyName("partner-nationality")]
        public object? PartnerNationality { get; set; }

        [JsonPropertyName("generate-barcode")]
        public bool GenerateBarcode { get; set; }

        [JsonPropertyName("is-print-ticket-before-journey-badge")]
        public bool IsPrintTicketBeforeJourneyBadge { get; set; }

        [JsonPropertyName("is-print-ticket-before-journey-mail")]
        public bool IsPrintTicketBeforeJourneyMail { get; set; }

        [JsonPropertyName("is-show-fare-rules")]
        public bool IsShowFareRules { get; set; }

        [JsonPropertyName("is-different-seat-price")]
        public bool IsDifferentSeatPrice { get; set; }

        [JsonPropertyName("redirect-to-checkout")]
        public bool RedirectToCheckout { get; set; }

        [JsonPropertyName("is-show-rating-avarage")]
        public bool IsShowRatingAvarage { get; set; }

        [JsonPropertyName("partner-route-rating")]
        public double PartnerRouteRating { get; set; }

        [JsonPropertyName("partner-route-rating-vote-count")]
        public int PartnerRouteRatingVoteCount { get; set; }

        [JsonPropertyName("partner-rating-vote-count")]
        public int? PartnerRatingVoteCount { get; set; }

        [JsonPropertyName("included-station-fee")]
        public bool IncludedStationFee { get; set; }

        [JsonPropertyName("is-domestic-route")]
        public bool IsDomesticRoute { get; set; }

        [JsonPropertyName("is-abroad-route")]
        public bool IsAbroadRoute { get; set; }

        [JsonPropertyName("has-partner-coupon-usage")]
        public bool HasPartnerCouponUsage { get; set; }

        [JsonPropertyName("disable-sales-without-passport-expiration-date")]
        public bool DisableSalesWithoutPassportExpirationDate { get; set; }

        [JsonPropertyName("transfer-count")]
        public int TransferCount { get; set; }

        [JsonPropertyName("is-national-identity-number-validator")]
        public bool IsNationalIdentityNumberValidator { get; set; }

        [JsonPropertyName("national-identity-validation-rules")]
        public object? NationalIdentityValidationRules { get; set; }

        [JsonPropertyName("internet-price-rate")]
        public object? InternetPriceRate { get; set; }

        [JsonPropertyName("journey-detail-carrier-base")]
        public object? JourneyDetailCarrierBase { get; set; }

        [JsonPropertyName("has-shuttle-selection")]
        public bool HasShuttleSelection { get; set; }

        [JsonPropertyName("origin-station-id")]
        public int OriginStationId { get; set; }

        [JsonPropertyName("destination-station-id")]
        public int DestinationStationId { get; set; }

        [JsonPropertyName("has-available-seat-info")]
        public bool HasAvailableSeatInfo { get; set; }

        [JsonPropertyName("has-seat-selection-method")]
        public bool HasSeatSelectionMethod { get; set; }

        [JsonPropertyName("has-journey-shuttle")]
        public bool HasJourneyShuttle { get; set; }

        [JsonPropertyName("is-full-address")]
        public bool IsFullAddress { get; set; }

        [JsonPropertyName("display-offset-started")]
        public string? DisplayOffsetStarted { get; set; }

        [JsonPropertyName("display-offset-after-min")]
        public object? DisplayOffsetAfterMin { get; set; }

        [JsonPropertyName("is-send-order-completion-pdf")]
        public bool IsSendOrderCompletionPdf { get; set; }

        [JsonPropertyName("show-shuttle-stops-by-passenger")]
        public bool ShowShuttleStopsByPassenger { get; set; }
    }

    public class Feature
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("is-promoted")]
        public bool IsPromoted { get; set; }
        [JsonPropertyName("back-color")]
        public string? BackColor { get; set; }
        [JsonPropertyName("fore-color")]
        public string? ForeColor { get; set; }
        [JsonPropertyName("partner-notes")]
        public object? PartnerNotes { get; set; }
    }

    public class Journey
    {
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        [JsonPropertyName("stops")]
        public List<Stop> Stops { get; set; }
        [JsonPropertyName("origin")]
        public string? Origin { get; set; }
        [JsonPropertyName("destination")]
        public string? Destination { get; set; }
        [JsonPropertyName("departure")]
        public DateTime Departure { get; set; }
        [JsonPropertyName("arrival")]
        public DateTime Arrival { get; set; }
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        [JsonPropertyName("duration")]
        public string? Duration { get; set; }
        [JsonPropertyName("original-price")]
        public double OriginalPrice { get; set; }
        [JsonPropertyName("internet-price")]
        public double InternetPrice { get; set; }
        [JsonPropertyName("provider-internet-price")]
        public double? ProviderInternetPrice { get; set; }
        [JsonPropertyName("booking")]
        public object? Booking { get; set; }
        [JsonPropertyName("bus-name")]
        public string? BusName { get; set; }
        [JsonPropertyName("policy")]
        public Policy Policy { get; set; }
        [JsonPropertyName("features")]
        public List<string> Features { get; set; } = new List<string>();
        [JsonPropertyName("features-description")]
        public object? FeaturesDescription { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("available")]
        public object? Available { get; set; }
        [JsonPropertyName("partner-provider-code")]
        public object? PartnerProviderCode { get; set; }
        [JsonPropertyName("peron-no")]
        public object? PeronNo { get; set; }
        [JsonPropertyName("partner-provider-id")]
        public object? PartnerProviderId { get; set; }
        [JsonPropertyName("is-segmented")]
        public bool IsSegmented { get; set; }
        [JsonPropertyName("partner-name")]
        public object? PartnerName { get; set; }
        [JsonPropertyName("provider-code")]
        public object? ProviderCode { get; set; }
        [JsonPropertyName("sorting-price")]
        public double SortingPrice { get; set; }
        [JsonPropertyName("has-multiple-brandedfare-selection")]
        public bool HasMultipleBrandedFareSelection { get; set; }
        [JsonPropertyName("has-available-seat-info")]
        public bool HasAvailableSeatInfo { get; set; }
        [JsonPropertyName("duration-offset")]
        public string? DurationOffset { get; set; }
    }

    public class Policy
    {
        [JsonPropertyName("max-seats")]
        public object? MaxSeats { get; set; }
        [JsonPropertyName("max-single")]
        public int? MaxSingle { get; set; }
        [JsonPropertyName("max-single-males")]
        public int? MaxSingleMales { get; set; }
        [JsonPropertyName("max-single-females")]
        public int? MaxSingleFemales { get; set; }
        [JsonPropertyName("mixed-genders")]
        public bool MixedGenders { get; set; }
        [JsonPropertyName("gov-id")]
        public bool GovId { get; set; }
        [JsonPropertyName("lht")]
        public bool Lht { get; set; }
    }

    public class Stop
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("kolayCarLocationId")]
        public int? KolayCarLocationId { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("station")]
        public string? Station { get; set; }
        [JsonPropertyName("time")]
        public DateTime? Time { get; set; }
        [JsonPropertyName("is-origin")]
        public bool IsOrigin { get; set; }
        [JsonPropertyName("is-destination")]
        public bool IsDestination { get; set; }
        [JsonPropertyName("is-segment-stop")]
        public bool IsSegmentStop { get; set; }
        [JsonPropertyName("index")]
        public int Index { get; set; }
        [JsonPropertyName("obilet-station-id")]
        public object? ObiletStationId { get; set; }
        [JsonPropertyName("map-url")]
        public object? MapUrl { get; set; }
        [JsonPropertyName("station-phone")]
        public object? StationPhone { get; set; }
        [JsonPropertyName("station-address")]
        public object? StationAddress { get; set; }
        [JsonPropertyName("tz-code")]
        public string? TzCode { get; set; }
    }

    public class GetBusJourneysResponse
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("data")]
        public List<Datum> Data { get; set; }
        [JsonPropertyName("message")]
        public object? Message { get; set; }
        [JsonPropertyName("user-message")]
        public object? UserMessage { get; set; }
        [JsonPropertyName("api-request-id")]
        public object? ApiRequestId { get; set; }
        [JsonPropertyName("controller")]
        public string? Controller { get; set; }
        [JsonPropertyName("client-request-id")]
        public object? ClientRequestId { get; set; }
        [JsonPropertyName("web-correlation-id")]
        public object? WebCorrelationId { get; set; }
        [JsonPropertyName("correlation-id")]
        public string? CorrelationId { get; set; }
        [JsonPropertyName("parameters")]
        public object? Parameters { get; set; }
    }
}