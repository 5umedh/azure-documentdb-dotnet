using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StreamOneOrderService.Domain
{
    public class Subscription:ProvisionSettings
    {
        /// <summary>
        /// Gets the GUID for subscription
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Order's Id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets Order's Key
        /// </summary>
        public string OrderKey { get; set; }

        /// <summary>
        /// The subscription key that remains constant amongst the history lines
        /// and this is the orderline ID
        /// </summary>
       
        public string SubscriptionKey { get; set; }

        [JsonProperty("resellerKey")]
        public string ResellerKey { get; set; }

        /// <summary>
        /// The parent subscription key for this addon
        /// and this is the orderline ID
        /// </summary>
        public string ParentSubscriptionKey { get; set; }
        /// <summary>
        /// The subscription key from Vendor response
        /// </summary>
        public string VendorSubscriptionKey { get; set; }

        /// <summary>
        /// The subscription key  of a parent from Vendor response
        /// </summary>
        public string ParentVendorSubscriptionKey { get; set; }

        /// <summary>
        /// CustomerKey identifier
        /// </summary>
        public string CustomerKey { get; set; }

        public string ProductKey { get; set; }

        public string ProductName { get; set; }

        public string ProductConfigName { get; set; }

        public string  VendorKey { get; set; }
        
        public string ProductConfigKey { get; set; }

        public string VendorProductConfigKey { get; set; }

        public string VendorSubscriptionDisplayName { get; set; }

        /// <summary>
        /// Error response after processing Provisioning, if any 
        /// </summary>
        public VendorProvisionResponse VendorProvisionResponse { get; set; }

        /// <summary>
        /// Gets or sets the subscription status
        /// </summary>
        public SubscriptionStatusEnum? SubscriptionStatus { get; set; }

        /// <summary>
        /// Gets or sets the subscription status
        /// </summary>
        public ProvisioningStatusEnum? ProvisioningStatus { get; set; }

        /// <summary>
        /// Gets or sets the subscription quantity
        /// </summary>
        public int Quantity { get; set; }


        /// <summary>
        ///  Get or sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the date and time of subscription provisioning
        /// </summary>
        public DateTime ProvisionedOnUtc { get; set; }

        /// <summary>
        /// Gets or Sets the Vendor Provision error message
        /// </summary>
        public string VendorErroMessage { get; set; }
        
        /// <summary>
        /// Defines whether subscrioption is for new customer
        /// </summary>
        public string IsNewCustomer { get; set; }

        public bool UseDefaultSubscriptionName { get; set; }

        public LastProvisionRequestTypeEnum? LastProvisionRequestType { get; set; }

        /// <summary>
        /// Gets or sets the date and time of subscription creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }
        
        /// <summary>
        /// Gets or sets the date and time of subscription update
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }


        public UnitTypeEnum? UnitType { get; set; }

        /// <summary>
        /// Gets or sets CreatedBy 
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets UpdatedBy
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        ///     Gets or sets billing frequency
        /// </summary>
        public ProductBillingFrequencyEnum? BillingFrequency { get; set; }

        /// <summary>
        ///     Gets or sets billing type
        /// </summary>
        public ProductBillingTypeEnum? BillingType { get; set; }

        /// <summary>
        /// Payment method type from paymentMethod model
        /// </summary>
        public PaymentMethodTypeEnum? PaymentMethodType { get; set; }

        public string CardId { get; set; }

        public bool IsSandBox { get; set; }

        /// <summary>
        /// Total number of purchased addon items for subscription
        /// </summary>
        public int TotalPurchasedAddOns { get; set; }
    }

    
    public class SubscriptionRequest
    {
        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets Order's Key
        /// </summary>
        public string OrderKey { get; set; }

        /// <summary>
        /// Get or sets the list of order line items
        /// </summary>
        public List<OrderLine> OrderLines { get; set; }

        /// <summary>
        /// Gets or sets CreatedBy 
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets UpdatedBy
        /// </summary>
        public string UpdatedBy { get; set; }

        [JsonProperty("resellerKey")]
        public string ResellerKey { get; set; }

        /// <summary>
        /// Payment method type from paymentMethod model
        /// </summary>
        public PaymentMethodTypeEnum? PaymentMethodType { get; set; }

        public string CardId { get; set; }
    }

    public enum LastProvisionRequestTypeEnum
    {
        InitialProvision = 0,

        StatusChange = 1,

        SeatChange = 2,


        PaymentChange = 3,



    }

   
    public enum SubscriptionStatusEnum
    {
        
        //TODO add/modify more status later
        NoStatus = 0,

        
        Active = 1, // after successful vendor proviosioning

        
        Suspended = 2, // can be reactivated

        
        Cancelled = 3 // can't be reactivated
    }

   
    public enum ProvisioningStatusEnum
    {
        
        
        TCPending = 0, // Terms & Conditions acceptance pending from reseller or end user
        
        ProvisioningPending = 1,
        
        ProvisionInProgress = 2,        
        
        ProvisioningFailed = 3,
        
        ProvisioningSuccess = 4
    }

   
}
